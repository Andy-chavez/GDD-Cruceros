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
            llenardataGridView(dataGridTramosPosibles);

        }

        private void listaDeTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT id_origen,id_destino,precio_base FROM [LEISTE_EL_CODIGO?].TramosDisponibles", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }


        private void botonEliminar_Click(object sender, EventArgs e)
        {
            VentanaBorrarTramo ventana = new VentanaBorrarTramo();
            ventana.Show();

        }

        int orden = 1;

        private void botonTramo_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowTramo = this.dataGridTramosPosibles.CurrentRow;

            string origen = rowTramo.Cells["id_origen"].Value.ToString();
            string destino = rowTramo.Cells["id_destino"].Value.ToString();
            decimal precio = Convert.ToDecimal(rowTramo.Cells["precio_base"].Value);

            Tramo tramoElegido = new Tramo(0, 0, origen, destino, orden, precio);

            if (RecorridoActualizado.Items.Count == 0)
            {

                listaTramos.Add(tramoElegido);
                RecorridoActualizado.Items.Add(("Origen: " + tramoElegido.id_origen + " - Destino: " + tramoElegido.destino + " - Precio: "+tramoElegido.precio));
                orden++;
            }
            else
            {

                if (listaTramos.Last().destino == tramoElegido.id_origen)
                {
                    listaTramos.Add(tramoElegido);
                    RecorridoActualizado.Items.Add(("Origen: " + tramoElegido.id_origen + " - Destino: " + tramoElegido.destino + " - Precio: " + tramoElegido.precio));
                    orden++;
                }
                else
                {
                    MessageBox.Show("Tramos inconexos, elija un tramo que se conecte con el anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }


        }

        private void filtroOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(dataGridTramosPosibles, "SELECT id_origen,id_destino,precio_base FROM [LEISTE_EL_CODIGO?].TramosDisponibles WHERE id_origen LIKE ('" + filtroOrigen.Text + "%') AND id_destino LIKE ('" + filtroDestino.Text + "%')");

        }

        private void listaDeTramos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Recorrido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Recorrido_DoubleClick(object sender, EventArgs e)
        {

        }

        private void botonSacarTramo_Click(object sender, EventArgs e)
        {
            if (RecorridoActualizado.Items.Count > 0)
            {

                RecorridoActualizado.Items.RemoveAt(RecorridoActualizado.Items.Count - 1);
                listaTramos.Remove(listaTramos.Last());
                orden--;
            }
            else
            {
                MessageBox.Show("No hay tramos para sacar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            string primerOrigen = listaTramos.First().id_origen;
            string ultimoDestino = listaTramos.Last().destino;
            decimal idRec;
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearRecorrido");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = primerOrigen;
                procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = ultimoDestino;
                procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                idRec = Convert.ToDecimal(procedure.Parameters["@idRecorrido"].Value);
            }
            catch
            {
                MessageBox.Show("No se pudo crear el recorrido, error desconocido");
                return;
            }
            for(int i = 1; i < orden; i++)
            {
                try
                {
                    BaseDeDato bd = new BaseDeDato();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearTramo");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = idRec;
                    procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = listaTramos[i-1].id_origen;
                    procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = listaTramos[i - 1].destino;
                    procedure.Parameters.Add("@orden", SqlDbType.SmallInt).Value = Convert.ToInt16(i);
                    procedure.Parameters.Add("@precio", SqlDbType.Decimal).Value = listaTramos[i-1].precio;
                    procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd.ejecutarConsultaDevuelveInt(procedure);
                    int result = Convert.ToInt32(procedure.Parameters["@retorno"].Value);
                    switch (result)
                    {
                        case 1:
                            break;
                        case -1:
                            MessageBox.Show("El origen y destino del tramo "+i+" son el mismo");
                            BajarRecFallido(idRec);
                            return;
                        case -2:
                            MessageBox.Show("El origen del tramo "+i+" no coincide con el destino del tramo anterior");
                            BajarRecFallido(idRec);
                            return;
                        default:
                            MessageBox.Show("No se pudo crear el recorrido, error desconocido");
                            BajarRecFallido(idRec);
                            return;
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el recorrido, error desconocido");
                    return;
                }
            }
            MessageBox.Show("Recorrido creado correctamente");
        }

        private void BajarRecFallido(decimal idRec)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darDeBajaRecorrido");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = idRec;
                int result = bd.ejecutarConsultaDevuelveInt(procedure);
            }
            catch
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            filtroDestino.Clear();
            filtroOrigen.Clear();
            botonBuscar_Click(null, null);
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
