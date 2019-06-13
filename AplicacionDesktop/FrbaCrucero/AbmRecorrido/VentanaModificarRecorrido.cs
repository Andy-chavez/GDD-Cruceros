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
    public partial class VentanaModificarRecorrido : Form
    {
        public VentanaModificarRecorrido()
        {
            InitializeComponent();
        }

        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();

        private void recorridosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenardataGridView(DataGridView dgv,string nombreConsulta)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand(nombreConsulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void VentanaModificarRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(recorridosActuales,"SELECT * FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
            llenardataGridView(tramosDisponibles,"SELECT * FROM [LEISTE_EL_CODIGO?].TramosDisponibles");
        }

        private void tramosDisponibles_CellContentClick()
        {
        
        }
    }
}
