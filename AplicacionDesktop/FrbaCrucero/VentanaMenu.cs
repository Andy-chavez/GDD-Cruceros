using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmRol;
using FrbaCrucero.AbmRecorrido;






namespace FrbaCrucero
{
    public partial class VentanaMenu : Form
    {
        

        public VentanaMenu()

        {
            InitializeComponent();
            this.Visible = false;
           
        }
        

        private void VentanaMenu_Load(object sender, EventArgs e)
        {
          
            
        }

        public void botonAdmCrucero_Click(object sender, EventArgs e)
        {
            
            
        }

        public void botonPago_Click(object sender, EventArgs e)
        {

        }

        public void botonReserva_Click(object sender, EventArgs e)
        {

        }

        

        public void botonAdmRecorrido_Click(object sender, EventArgs e)
        {
            new VentanaGestionRecorrido(this).ShowDialog();
        }

        public void botonAbmRol_Click(object sender, EventArgs e)
        {
            new VentanaGestionRol(this).ShowDialog();
        }

        public void botonViaje_Click(object sender, EventArgs e)
        {

        }

        public void botonEstadisticas_Click(object sender, EventArgs e)
        {

        }
        public void ocultarBotones( )
        {
            botonAdmRecorrido.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
           Application.Exit();

        }

       

    }
}
