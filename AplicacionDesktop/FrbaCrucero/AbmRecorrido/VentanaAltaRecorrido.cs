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
using System.Security.Cryptography;
using System.Data.SqlTypes;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class VentanaAltaRecorrido : Form
    {

        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<Tramo> listaTramos = new List<Tramo>();

        public VentanaAltaRecorrido()
        {
            InitializeComponent();
        }

        private void VentanaAltaRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(dataGridView1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
 
            public void llenardataGridView(DataGridView dgv)
        
        {         
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles",conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);         
            adapter.Fill(dt);
            dgv.DataSource = dt;
           bd.desconectar();
        }


        private void botonEliminar_Click(object sender, EventArgs e)
        {
           VentanaTramo ventana = new VentanaTramo();
           ventana.Show();
          
        }

        private void botonTramo_Click(object sender, EventArgs e)
        {
           VentanaTramo ventana = new VentanaTramo();
           ventana.Show();
           ventana.esconderBotonEliminar();
           
        }

        private void filtroOrigen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlDataAdapter consulta = new SqlDataAdapter("", conexion);

        }
    }
}
