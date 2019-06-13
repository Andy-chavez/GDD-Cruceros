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
    public partial class VentanaRolSeleccionado : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();

        public VentanaRolSeleccionado()
        {
            InitializeComponent();
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(listaFunc);

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
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].TramosDisponibles", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void listaFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }


    }
}
