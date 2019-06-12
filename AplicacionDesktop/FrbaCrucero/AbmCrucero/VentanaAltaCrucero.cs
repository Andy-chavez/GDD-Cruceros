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

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaAltaCrucero : Form
    {
        public VentanaAltaCrucero()
        {
            InitializeComponent();
        }

        private void VentanaAltaCrucero_Load(object sender, EventArgs e)
        {

        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
         
            Crucero crucero = new Crucero();
            crucero.crearCrucero(textoIdCrucero.Text, texoIdFabricante.Text , textoModelo.Text , Convert.ToInt32(textoCabina.Text));
        }

        private void textoIdCrucero_TextChanged(object sender, EventArgs e)
        {

        }

        private void texoIdFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoCabina_TextChanged(object sender, EventArgs e)
        {

        }

        public bool todosLosCamposEstancompletos()
        {

            return textoIdCrucero.Text != "" && texoIdFabricante.Text != "" && textoModelo.Text != "" && textoCabina.Text != "";

        }
    }
}
