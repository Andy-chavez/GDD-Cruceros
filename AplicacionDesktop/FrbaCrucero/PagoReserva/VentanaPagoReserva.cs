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

namespace FrbaCrucero.PagoReserva
{
    public partial class VentanaPagoReserva : Form
    {
        BaseDeDato bd = new BaseDeDato();
        DataTable dt = new DataTable();
        SqlDataAdapter adapt;
        public VentanaPagoReserva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].comprarPasajeReservado");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idReserva", SqlDbType.NVarChar).Value = comboBoxReserva.Text;
                procedure.Parameters.Add("@idPago", SqlDbType.NVarChar).Value = comboBoxPago.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1)
                {
                    MessageBox.Show("Pago exitoso");
                    VentanaMenu menu = new VentanaMenu();
                    this.Hide();
                }
                else if (retorno == -1)
                { 
                    MessageBox.Show("El cliente ya tiene viajes en esa fecha");
                }
                else if (retorno == -2) 
                { 
                    MessageBox.Show("No Existe Reserva o la reserva expiro");
                }
                //this.Hide();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void VentanaPagoReserva_Load_1(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_reserva from [LEISTE_EL_CODIGO?].Reserva", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxReserva.DataSource = dt;
            comboBoxReserva.ValueMember = "id_reserva";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_pago from [LEISTE_EL_CODIGO?].PagoDeViaje", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxPago.DataSource = dt;
            comboBoxPago.ValueMember = "id_pago";
            bd.desconectar();
        }
    }
}
