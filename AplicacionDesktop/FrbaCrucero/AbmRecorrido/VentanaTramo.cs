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
using System.Data.SqlClient;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class VentanaTramo : Form
    {

        public VentanaTramo()
        {
            InitializeComponent();
        }

        private void VentanaTramo_Load(object sender, EventArgs e)
        {
            this.llenarCombo(listaOrigen, "SELECT id_origen FROM [LEISTE_EL_CODIGO?].Tramo");
            this.llenarCombo(listaDestino, "SELECT id_destino FROM [LEISTE_EL_CODIGO?].Tramo");
        }
        public void esconderBotonEliminar()
        {
            this.botonEliminar.Hide();
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposEstancompletos())
            {
                string origen = (string)listaOrigen.SelectedItem;
                string destino = (string)listaDestino.SelectedItem;
                int precio = Convert.ToInt16(textoPrecio.Text);
                Tramo tramo = new Tramo();
                tramo.crearTramo(origen, destino, precio);
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool todosLosCamposEstancompletos()
        {

            return listaDestino.Text != "" && listaOrigen.Text != "" && textoPrecio.Text != "";

        }

        private void listaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textoPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            listaDestino.SelectedIndex = -1;
            listaOrigen.SelectedIndex = -1;
            textoPrecio.Clear();
        }
        public void llenarCombo(ComboBox cb, string consultaDeObtencion)
        {

            BaseDeDato db = new BaseDeDato();
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].Tramo", conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            cb.DataSource = listaDeTramos;
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();
        }

    }


}
