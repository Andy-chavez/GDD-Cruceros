using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaCrucero.AbmCrucero
{

    public partial class VentanaGestionCrucero : Form
    {

        #region Atributos

        public VentanaMenu ventanaMenu { get; set; }

        #endregion

        public VentanaGestionCrucero(VentanaMenu ventanaMenu)
        {
            InitializeComponent();
            this.ventanaMenu = ventanaMenu;

        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new VentanaDeAltaCrucero().Show();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            new VentanaModificarCrucero().Show();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            new VentanaListadoCrucero().Show();
        }

        private void VentanaGestionCrucero_Load(object sender, EventArgs e)
        {

        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            new ventanaDeBajaCrucero().Show();
        }
    }
}
