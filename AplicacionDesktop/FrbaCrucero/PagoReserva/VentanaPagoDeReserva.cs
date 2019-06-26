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
using System.Data.SqlTypes;

namespace FrbaCrucero.PagoReserva
{
    public partial class VentanaPagoDeReserva : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
        SqlDataAdapter adapt;
        public string fechaConfig = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];
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
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].comprarPasajeReservado");
                DateTime enteredDate = DateTime.Parse(fechaConfig);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idReserva", SqlDbType.NVarChar).Value = System.Convert.ToDecimal(reserva.Text);
                procedure.Parameters.Add("@idMedioDePago", SqlDbType.NVarChar).Value = comboBoxMedios.Text;
                procedure.Parameters.AddWithValue("@fechaConfig", SqlDbType.DateTime).Value = enteredDate;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Reserva pagada exitosamente.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private void VentanaPagoDeReserva_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_medio_de_pago from [LEISTE_EL_CODIGO?].MedioDePago", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxMedios.DataSource = dt;
            comboBoxMedios.ValueMember = "id_medio_de_pago";
            bd.desconectar();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void ComboBoxMedios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
