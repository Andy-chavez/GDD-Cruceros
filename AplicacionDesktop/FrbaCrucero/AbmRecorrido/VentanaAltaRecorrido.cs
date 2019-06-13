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

                int id = Convert.ToInt32(listaDeTramos.Rows[e.RowIndex].Cells["id_tramo"].Value.ToString());
                decimal id_reco = Convert.ToDecimal(listaDeTramos.Rows[e.RowIndex].Cells["id_recorrido"].Value.ToString());
                string origen = listaDeTramos.Rows[e.RowIndex].Cells["id_origen"].Value.ToString();
                string destino = listaDeTramos.Rows[e.RowIndex].Cells["id_destino"].Value.ToString();
                int orden = Convert.ToInt32(listaDeTramos.Rows[e.RowIndex].Cells["orden"].Value.ToString());
                decimal precio_base = Convert.ToDecimal(listaDeTramos.Rows[e.RowIndex].Cells["precio_base"].Value.ToString());
                Tramo tramoElegido = new Tramo(id, id_reco, origen, destino, orden, precio_base);


                if (Recorrido.Items.Count == 0)
                {

                    listaTramos.Add(tramoElegido);
                    Recorrido.Items.Add(("Origen: " + tramoElegido.id_origen + "  Destino" + tramoElegido.destino));
                }
                else
                {

                    if (listaTramos.Last().destino == tramoElegido.id_origen)
                    {
                        listaTramos.Add(tramoElegido);
                        Recorrido.Items.Add(("Origen: " + tramoElegido.id_origen + "  Destino" + tramoElegido.destino));
                    }
                    else
                    {
                        MessageBox.Show("Tramos inconexos, eliga un tramo que se conecte con el anterior:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
        }

        private void Recorrido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
