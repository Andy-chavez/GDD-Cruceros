using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    public partial class VentanaGestionarPuerto : Form
    {
        #region Atributos

        public VentanaMenu ventanaMenu { get; set; }

        #endregion


        public VentanaGestionarPuerto(VentanaMenu ventanaMenu)
        {
            InitializeComponent();
            this.ventanaMenu = ventanaMenu;
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new VentanaDeAltaPuerto().Show();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            new VentanaSeleccionPuerto().Show();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            new VentanaListadoPuerto().Show();
        }

        private void VentanaGestionarPuerto_Load(object sender, EventArgs e)
        {

        }
    }
}
