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
        public VentanaGestionCrucero()
        {
            InitializeComponent();
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new VentanaAltaCrucero().Show();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
           VentanaModificarCrucero ventanaModificar = new VentanaModificarCrucero();
           ventanaModificar.Show();
           ventanaModificar.esconderCosasDeBaja();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {

         VentanaModificarCrucero ventanaMod = new VentanaModificarCrucero();
            ventanaMod.Show();
            ventanaMod.esconderCosasDeModificar();
        }

        private void VentanaGestionCrucero_Load(object sender, EventArgs e)
        {

        }
    }
}
