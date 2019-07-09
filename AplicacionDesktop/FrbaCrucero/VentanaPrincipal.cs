using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Clases;
using System.Configuration;

namespace FrbaCrucero
{
    
      

    public partial class VentanaPrincipal : Form
    {

        public string fechaConfig = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];
        public VentanaPrincipal()
        {
            InitializeComponent();
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonSesionUsuario_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].sp_login");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@id_ingresado", SqlDbType.NVarChar).Value = casillaUsuario.Text;
                procedure.Parameters.Add("@contra_ingresada", SqlDbType.NVarChar).Value = casillaContraseña.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if(retorno == 1)
                {
                    //SqlCommand reservasVencidas = Clases.BaseDeDato.crearConsulta();
                    SqlCommand reservasVencidas = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarReservasVencidas");
                    reservasVencidas.CommandType = CommandType.StoredProcedure;
                    DateTime enteredDate = DateTime.Parse(fechaConfig);
                    reservasVencidas.Parameters.AddWithValue("@fechaConfig", SqlDbType.DateTime).Value = enteredDate;
                    bd.ejecutarConsultaSinResultado(reservasVencidas);
                    VentanaMenu menu = new VentanaMenu();
                    this.Hide();
                    menu.Show();
                    menu.ocultarBotones(casillaUsuario.Text);
                }
                else if (retorno == 0){ //hay intentos todavia
                    MessageBox.Show("Contraseña incorrecta, pruebe nuevamente");
                    casillaContraseña.Clear();
                }
                else if (retorno == -1){ //baja logica
                    MessageBox.Show("Se excedió la cantidad de intentos posibles");
                    this.Hide();
                }
                else
                { //no existe usuario
                    MessageBox.Show("No Existe Usuario");
                    casillaUsuario.Clear();
                    casillaContraseña.Clear();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void botonSesionCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseDeDato bd = new BaseDeDato();
            SqlCommand reservasVencidas = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarReservasVencidas");
            reservasVencidas.CommandType = CommandType.StoredProcedure;
            DateTime enteredDate = DateTime.Parse(fechaConfig);
            reservasVencidas.Parameters.AddWithValue("@fechaConfig", SqlDbType.DateTime).Value = enteredDate;
            bd.ejecutarConsultaSinResultado(reservasVencidas);
            VentanaMenu menu = new VentanaMenu();
            menu.Show();
            menu.ocultarBotones("cliente");
            
        }

        private void casillaUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void casillaContraseña_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public static void ventanaErrorBD(Exception excepcion)
        {
            MessageBox.Show("ERROR EN LA BASE DE DATOS:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ventanaIntentoExitoso(string mensaje)
        {
            MessageBox.Show("AVISO: " + mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ventanaError(string mensaje)
        {
            MessageBox.Show("ERROR: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
