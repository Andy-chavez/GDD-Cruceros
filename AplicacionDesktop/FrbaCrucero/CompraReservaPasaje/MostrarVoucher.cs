using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using FrbaCrucero.PagoReserva;
using System.Data.SqlClient;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class MostrarVoucher : Form
    {
        Compra compra;
        VentanaPagoDeReserva pagoRes;
        public MostrarVoucher(int id_pago, Compra compra, VentanaPagoDeReserva pagoRes)
        {
            if (compra != null) this.compra = compra;
            else if (pagoRes != null) this.pagoRes = pagoRes;
            InitializeComponent();
            Voucher(id_pago);
            this.FormClosing += Cerrando;
        }

        void Cerrando(Object sender, FormClosingEventArgs e)
        {
            if (compra != null) compra.CerrarPorOperacionTerminada();
            else if (pagoRes != null) pagoRes.CerrarPorOperacionTerminada();
        }

        public void Voucher(int id_pago)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].verVoucher");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idPago", SqlDbType.Int).Value = id_pago;
                dt = bd.obtenerDataTable(procedure);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
