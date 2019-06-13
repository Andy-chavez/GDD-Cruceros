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

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaModificarCrucero : Form
    {
        public VentanaModificarCrucero()
        {
            InitializeComponent();
        }

        BaseDeDato bd = new BaseDeDato();
        DataTable dt = new DataTable();

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void VentanaModificarCrucero_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(dataGridView1);
        }
    }
}
