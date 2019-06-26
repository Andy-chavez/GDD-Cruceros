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
    public partial class VentanaPagoDeReserva : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
        SqlDataAdapter adapt;
        public VentanaPagoDeReserva()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
 /*           try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].comprarPasajeReservado");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idReserva", SqlDbType.NVarChar).Value = System.Convert.ToDecimal(reserva.Text);
                procedure.Parameters.Add("@idPago", SqlDbType.NVarChar).Value = System.Convert.ToInt32(pago.Text);
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Pago asociado exitosamente.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pago.Clear();
                    reserva.Clear();

                }
                else if (retorno == -2) // no existe reserva o se vencio
                {
                    MessageBox.Show("La reserva ingresada no existe o ya ha cadudado.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (retorno == -1) // el cliente ya tiene viajes en esa fecha
                {
                    MessageBox.Show("El cliente del pasaje reservado ya tenia viajes pagados en la fecha de dicha reserva.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }*/
        }
    }
}
