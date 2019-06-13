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

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaModificarRol : Form
    {
        public VentanaModificarRol()
        {
            InitializeComponent();
        }

        Rol rol = new Rol();
        BaseDeDato bd = new BaseDeDato();

        SqlDataAdapter adapt;
        DataTable dt;// = new DataTable();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaModificarRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select nombre from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "nombre";
            bd.desconectar();

        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            new VentanaRolSeleccionado().Show();
        }

        public void botonEliminar_Click(object sender, EventArgs e)
        {
            rol.eliminarRol(seleccion.ToString());
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            seleccion.Clear();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccion_TextChanged(object sender, EventArgs e)
        {

        }
        public void esconderBotonEliminar()
        {
            this.botonEliminar.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
