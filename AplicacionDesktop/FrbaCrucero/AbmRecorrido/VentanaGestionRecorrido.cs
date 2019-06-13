using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class VentanaGestionRecorrido : Form
    {
        #region Atributos

        public VentanaMenu ventanaMenu { get; set; }

        #endregion

        public VentanaGestionRecorrido(VentanaMenu ventanaMenu)
        {
            InitializeComponent();
            this.ventanaMenu = ventanaMenu;

        }

        private void VentanaGestionRecorrido_Load(object sender, EventArgs e)
        {

        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new VentanaAltaRecorrido().Show();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            new VentanaModificarRecorrido().Show();
        }


    }
}
