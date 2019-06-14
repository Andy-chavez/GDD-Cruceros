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
        private Recorrido recorrido = new Recorrido();

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


        }

        private void filtroOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(listaDeTramos, "SELECT * FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles WHERE id_origen LIKE ('" + filtroOrigen.Text + "%') AND id_destino LIKE ('" + filtroDestino.Text + "%')");

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

        private void Recorrido_DoubleClick(object sender, EventArgs e)
        {

        }

        private void botonSacarTramo_Click(object sender, EventArgs e)
        {
            if (Recorrido.Items.Count > 0)
            {

                Recorrido.Items.RemoveAt(Recorrido.Items.Count - 1);
                listaTramos.Remove(listaTramos.Last());
            }
            else
            {
                MessageBox.Show("No hay tramos para sacar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            string primerOrigen = listaTramos.First().id_origen;
            string primerDestino = listaTramos.Last().destino;
            recorrido.crearRecorrido(primerOrigen, primerDestino);

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            filtroDestino.Clear();
            filtroOrigen.Clear();
            listaDeTramos.Refresh();
        }
        public void filtrarDataGrdView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlCommand consulta = new SqlCommand(nombreConsulta, bd.obtenerConexion());
            DataTable tabla = bd.obtenerDataTable(consulta);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            adapter.Fill(tabla);
            dgv.DataSource = tabla;
            bd.desconectar();
        }

        private void filtroDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
