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
using System.Data.SqlClient;
using System.Collections;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Compra : Form
    {
        private Cliente cliente;
        private int idViaje;
        int cant_pasajes;
        private ArrayList cabinas = new ArrayList();
        string idCrucero;


        private int id_pago;
        public Compra(Cliente cliente,int idViaje,ArrayList cabinas,string idCrucero, int cant_pasajes)
        {
            this.cant_pasajes = cant_pasajes;
            if(cabinas.Count == 0) throw new Exception("Error seleccione las cabinas antes de proceder con la compra");
            this.cabinas=cabinas;
            this.idCrucero = idCrucero;
            this.idViaje = idViaje;
            if(cliente is null) throw new Exception("Error Ingrese sus datos antes de realizar la compra");
            this.cliente = cliente;
            InitializeComponent();
        }
        public void RecibirIDPago(int id)
        {
            this.id_pago = id;
        }

        private void Compra_Load(object sender, EventArgs e)
        {

        }

        private void buttonMedio_Click(object sender, EventArgs e)
        {
            new VentanaMedioDePago(this, cliente.id).Show();
        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            //comprarPasaje (@idCliente int,@idViaje int,@idCabina int, @idCrucero int, @idPago int)
            //1: se cargo todo joya
            //-1: el cliente que quiere comprar ya tiene un viaje en esa fecha

            try
            {
                BaseDeDato bd = new BaseDeDato();

                for (int i = 0; i < cant_pasajes; i++)
                {
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].comprarPasaje");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@idCliente", SqlDbType.Int).Value = cliente.id;
                    procedure.Parameters.Add("@idViaje", SqlDbType.Int).Value = idViaje;
                    procedure.Parameters.Add("@idCabina", SqlDbType.Int).Value = (int) this.cabinas[i];
                    procedure.Parameters.Add("@idCrucero", SqlDbType.NVarChar).Value = idCrucero;
                    procedure.Parameters.Add("@idPago", SqlDbType.Int).Value = id_pago;
                    procedure.Parameters.Add("@ret", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd.ejecutarConsultaDevuelveInt(procedure);
                    int retorno = Convert.ToInt32(procedure.Parameters["@ret"].Value);
                    if (retorno==-1)
                    {
                        MessageBox.Show("Error: ya tiene viajes en esa fecha");
                        return;
                    }
                }
                new MostrarVoucher(id_pago).Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
