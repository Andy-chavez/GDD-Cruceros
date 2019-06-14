using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Data.SqlClient;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class MostrarVoucher : Form
    {
        public MostrarVoucher(int id_pago)
        {
            InitializeComponent();
            Voucher(id_pago);
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
