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
            if (this.todosLosCamposEstancompletos())
            {
                Crucero crucero = new Crucero();
                crucero.crearCrucero(textoIdCrucero.Text, texoIdFabricante.Text, textoModelo.Text, Convert.ToInt32(textoCabina.Text));
            }
            else
            {
                MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            textoCabina.Clear();
            textoIdCrucero.Clear();
            texoIdFabricante.Clear();
            textoModelo.Clear();
        }

        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
