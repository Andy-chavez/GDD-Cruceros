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
            
           
            this.Hide() ;
           
            }

        private void botonSesionCliente_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            

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
        
    }
}
