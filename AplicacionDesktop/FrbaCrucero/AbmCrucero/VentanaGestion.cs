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
    public partial class VentanaGestion : Form
    {
        public VentanaGestion()
        {
            InitializeComponent();
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new VentanaAltaCrucero().Show();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            new VentanaModificarCrucero().Show();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            new VentanaModificarCrucero().Show();
        }
    }
}
