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
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.AbmPuerto;




namespace FrbaCrucero
{
    public partial class VentanaMenu : Form
    {
        #region Atributos

        public VentanaPrincipal ventanaPrincipal { get; set; }

        #endregion

        public VentanaMenu(VentanaPrincipal ventanaPrincipal)

        {
            InitializeComponent();
            this.Visible = false;
            this.ventanaPrincipal = ventanaPrincipal;
        }
        

        private void VentanaMenu_Load(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show();
            
        }

        public void botonAdmCrucero_Click(object sender, EventArgs e)
        {
            new VentanaGestionCrucero(this).ShowDialog();
            
        }

        public void botonPago_Click(object sender, EventArgs e)
        {

        }

        public void botonReserva_Click(object sender, EventArgs e)
        {

        }

        public void botonAdmPuertos_Click(object sender, EventArgs e)
        {
            new VentanaGestionarPuerto(this).ShowDialog();
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
        public void ocultarBotones( List<Button> listaDeBotones)
        {
            foreach (Button boton in listaDeBotones)
            {
                boton.Hide();
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

    }
}
