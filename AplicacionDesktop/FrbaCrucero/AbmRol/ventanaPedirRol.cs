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
    public partial class ventanaPedirRol : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
        private String id;
        SqlDataAdapter adapt;
        public ventanaPedirRol()
        {
            InitializeComponent();
            this.llenarRoles();
        }
        private void llenarRoles()
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].RolesHabilitados", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id_rol";
            bd.desconectar();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            VentanaModificarRol ventana = new VentanaModificarRol(comboBox1.Text.ToString());
            ventana.Show();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentanaPedirRol_Load(object sender, EventArgs e)
        {

        }
    }
}
