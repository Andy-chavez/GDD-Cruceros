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
    public partial class VentanaAltaRecorrido : Form
    {


        public VentanaAltaRecorrido()
        {
            InitializeComponent();
        }

        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<Tramo> listaTramos = new List<Tramo>();

        private void VentanaAltaRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(listaDeTramos);

        }

        private void listaDeTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void listaDeTramos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listaDeTramos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                listaDeTramos.CurrentRow.Selected = true;

                string idTramo = listaDeTramos.Rows[e.RowIndex].Cells["id_tramo"].Value.ToString();
           /*      int  id    =  Convert.ToInt32(listaDeTramos.Rows[e.RowIndex].Cells["id_tramo"].Value.ToString());
                              Convert.ToDecimal(listaDeTramos.Rows[e.RowIndex].Cells["id_recorrido"].Value.ToString()),;
                              listaDeTramos.Rows[e.RowIndex].Cells["id_origen"].Value.ToString();
                              listaDeTramos.Rows[e.RowIndex].Cells["id_destino"].Value.ToString();
                              Convert.ToInt32(listaDeTramos.Rows[e.RowIndex].Cells["orden"].Value.ToString());
                              Convert.ToDecimal(listaDeTramos.Rows[e.RowIndex].Cells["precio_base"].Value.ToString()));
    */
                 Recorrido.Items.Add(idTramo);
                /*
                                foreach (DataGridViewRow fila in listaDeTramos.Rows)
                                {
                                    listaTramos.Add(new Tramo();
                                }

                                foreach (Tramo tramo in listaTramos)
                                {
                                    Recorrido.Items.Add(tramo.origen + " - " + tramo.destino);
                                }
 
                            }  
                            else
                            {

                                MessageBox.Show("No hay tramos para agregar", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           */
            }
        }

        private void Recorrido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
