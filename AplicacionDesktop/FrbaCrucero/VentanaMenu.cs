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
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.PagoReserva;




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
            new VentanaGestionCrucero().Show();
            
        }

        public void botonPago_Click(object sender, EventArgs e)
        {
            new VentanaPagoDeReserva().Show();
        }

        public void botonReserva_Click(object sender, EventArgs e)
        {
            new VentanaSeleccionarviaje().Show();
        }

        public void botonAdmRecorrido_Click(object sender, EventArgs e)
        {
            new VentanaGestionRecorrido(this).Show();
        }

        public void botonAbmRol_Click(object sender, EventArgs e)
        {
            new VentanaGestionRol(this).Show();
        }

        public void botonViaje_Click(object sender, EventArgs e)
        {
            new GenerarViaje().Show();
        }

        public void botonEstadisticas_Click(object sender, EventArgs e)
        {
            new ListadoEstadistico.ListadoEstadistico().Show();
        }
        public void ocultarBotones()
        {
            botonAdmRecorrido.Hide();
            botonAdmCrucero.Hide();
            botonAbmRol.Hide();
            botonEstadisticas.Hide();
            botonViaje.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
           Application.Exit();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new VentanaPagoDeReserva().Show();
        }
    }
}
