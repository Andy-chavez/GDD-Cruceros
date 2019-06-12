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


namespace FrbaCrucero
{
    
      

    public partial class VentanaPrincipal : Form
    {
      

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
            this.Hide();
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].sp_login");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@id_ingresado", SqlDbType.NVarChar).Value = casillaUsuario.Text;
                procedure.Parameters.Add("@contra_ingresada", SqlDbType.NVarChar).Value = casillaContraseña.Text;
                int retorno = bd.ejecutarConsultaDevuelveInt(procedure);
                if(retorno == 1)
                {
                    this.Hide();
                    VentanaMenu menu = new VentanaMenu();
                    menu.Show();
                }
                else if (retorno == 0){ //hay intentos todavia
                    MessageBox.Show("Contraseña incorrecta, pruebe nuevamente");

                }
                else if (retorno == -1){ //baja logica
                    MessageBox.Show("Se excedió la cantidad de intentos posibles");
                }
                else
                { //no existe usuario
                    MessageBox.Show("No Existe Usuario");
                }
                this.Close();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void botonSesionCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMenu menu = new VentanaMenu();
            menu.Show();
            menu.ocultarBotones();
            

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
