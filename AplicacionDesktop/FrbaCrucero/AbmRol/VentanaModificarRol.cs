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

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaModificarRol : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
        private Rol rol = new Rol();
        SqlDataAdapter adapt;
        public VentanaModificarRol()
        {
            InitializeComponent();
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(listaFunc);
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad,descripcion from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxFuncionalidades.DataSource = dt;
            comboBoxFuncionalidades.ValueMember = "descripcion";
            bd.desconectar();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void listaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void listaFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TextoRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
