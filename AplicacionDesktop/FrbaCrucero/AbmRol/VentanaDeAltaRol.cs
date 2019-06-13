using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Clases;
using System.Data.SqlTypes;

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaDeAltaRol : Form
    {
        public VentanaDeAltaRol()
        {
            InitializeComponent();
        }

        Rol rol = new Rol();

        private void VentanaDeAltaRol_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonCrear_Click(object sender, EventArgs e)
        {

            if (this.todosLosCamposEstancompletos())
            {
                this.agregarRol();
            }
            else
            {
                MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void textoNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {


        }
        private void agregarRol()
        {
            if (textoNombre.Text != "")
            {

                rol.crearRol(textoNombre.Text, Convert.ToInt32(listaFunc.SelectedValue));
                DialogResult result = MessageBox.Show("Rol creado exitosamente", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Nombre de rol vacío. Inserte el nombre del rol", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textoNombre.Clear();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarItems(ComboBox cb)
        {

        }

        private void listaFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool todosLosCamposEstancompletos()
        {

            return textoNombre.Text != "" && listaFunc.Text != "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
