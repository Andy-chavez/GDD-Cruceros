using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class TrueModificarRecorrido : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private List<Tramo> listaTramos = new List<Tramo>();
        int orden = 1;
        decimal idRec=-1;
        private DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);

        public TrueModificarRecorrido()
        {
            InitializeComponent();
        }

        private void TrueModificarRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(dataGridRecorridosActuales, "SELECT id_recorrido,id_origen,id_destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
        }
        public void llenardataGridView(DataGridView dgv,string msg)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand(msg, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void dataGridRecorridosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textoRecorridoSeleccionado.Text = dataGridRecorridosActuales.CurrentRow.Cells["id_recorrido"].Value.ToString();

            idRec = Convert.ToDecimal(dataGridRecorridosActuales.CurrentRow.Cells["id_recorrido"].Value);

            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            string msg = "SELECT id_tramo,id_origen,id_destino,orden,precio_base FROM [LEISTE_EL_CODIGO?].Tramo WHERE @idRec = id_recorrido";
            SqlCommand proc = new SqlCommand(msg, conexion);
            proc.Parameters.Add("@idRec", SqlDbType.Decimal).Value = Convert.ToDecimal(dataGridRecorridosActuales.CurrentRow.Cells["id_recorrido"].Value);
            SqlDataAdapter adapter = new SqlDataAdapter(proc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridTramosRecOrig.DataSource = dt;
            bd.desconectar();

            llenardataGridView(dataGridTramosDisp, "SELECT id_tramo,id_origen,id_destino,precio_base FROM [LEISTE_EL_CODIGO?].TramosDisponibles");

            listaTramos.Clear();
            listBoxNuevosTramos.Items.Clear();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            filtroDestino.Clear();
            filtroOrigen.Clear();
            textoRecorridoSeleccionado.Clear();
            buttonBuscar_Click(null, null);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(dataGridTramosDisp, "SELECT id_origen,id_destino,precio_base FROM [LEISTE_EL_CODIGO?].TramosDisponibles WHERE id_origen LIKE ('" + filtroOrigen.Text + "%') AND id_destino LIKE ('" + filtroDestino.Text + "%')");
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

        private void buttonAddTramo_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowTramo = this.dataGridTramosDisp.CurrentRow;

            string origen = rowTramo.Cells["id_origen"].Value.ToString();
            string destino = rowTramo.Cells["id_destino"].Value.ToString();
            decimal precio = Convert.ToDecimal(rowTramo.Cells["precio_base"].Value);

            Tramo tramoElegido = new Tramo(0, 0, origen, destino, orden, precio);

            if (listBoxNuevosTramos.Items.Count == 0)
            {

                listaTramos.Add(tramoElegido);
                listBoxNuevosTramos.Items.Add(("Origen: " + tramoElegido.id_origen + " - Destino: " + tramoElegido.destino + " - Precio: " + tramoElegido.precio));
                orden++;
            }
            else
            {

                if (listaTramos.Last().destino == tramoElegido.id_origen)
                {
                    listaTramos.Add(tramoElegido);
                    listBoxNuevosTramos.Items.Add(("Origen: " + tramoElegido.id_origen + " - Destino: " + tramoElegido.destino + " - Precio: " + tramoElegido.precio));
                    orden++;
                }
                else
                {
                    MessageBox.Show("Tramos inconexos, elija un tramo que se conecte con el anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrarLastTramo_Click(object sender, EventArgs e)
        {
            if (listBoxNuevosTramos.Items.Count > 0)
            {

                listBoxNuevosTramos.Items.RemoveAt(listBoxNuevosTramos.Items.Count - 1);
                listaTramos.Remove(listaTramos.Last());
                orden--;
            }
            else
            {
                MessageBox.Show("No hay tramos para sacar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (idRec < 0)
            {
                MessageBox.Show("Primero Elija el recorrido a modificar");
                return;
            }

            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].esRecorridoModificable");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = idRec;
                procedure.Parameters.Add("@fechaConfig", SqlDbType.DateTime).Value = fechaConfig;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int result = Convert.ToInt32(procedure.Parameters["@retorno"].Value);
                if (result == -1)
                {
                    MessageBox.Show("No se puede modificar este recorrido porque todavia hay pasajes vendidos q no hicieron el viaje");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo verificar que el recorrido es modificable");
                return;
            }

            if (listaTramos.First() == null)
            {
                MessageBox.Show("Indique los nuevos tramos");
                return;
            }
            string primerOrigen = listaTramos.First().id_origen;
            string ultimoDestino = listaTramos.Last().destino;

            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarTramosDelRecorrido");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@id_recorrido", SqlDbType.Decimal).Value = idRec;
                bd.ejecutarConsultaSinResultado(procedure);
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudieron borrar los tramos anteriores del recorrido, por favor vuelva a intentarlo");
                return;
            }
            for (int i = 1; i < orden; i++)
            {
                try
                {
                    BaseDeDato bd = new BaseDeDato();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearTramo");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = idRec;
                    procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = listaTramos[i-1].id_origen;
                    procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = listaTramos[i-1].destino;
                    procedure.Parameters.Add("@orden", SqlDbType.SmallInt).Value = Convert.ToInt16(i);
                    procedure.Parameters.Add("@precio", SqlDbType.Decimal).Value = listaTramos[i - 1].precio;
                    procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd.ejecutarConsultaDevuelveInt(procedure);
                    int result = Convert.ToInt32(procedure.Parameters["@retorno"].Value);
                    if (result != 1)
                    {
                        try
                        {
                            BaseDeDato db = new BaseDeDato();
                            SqlCommand proc = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarTramosDelRecorrido");
                            proc.CommandType = CommandType.StoredProcedure;
                            proc.Parameters.Add("@id_recorrido", SqlDbType.Decimal).Value = idRec;
                            db.ejecutarConsultaSinResultado(proc);
                        }
                        catch{}

                        MessageBox.Show("Se han perdido los datos del tramo,\n por favor vuelva a modificarlos", "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo modificar el recorrido, error desconocido");
                    return;
                }
            }

            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].modificarRecorrido");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = idRec;
                procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = primerOrigen;
                procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = ultimoDestino;
                procedure.Parameters.Add("@fechaConfig", SqlDbType.DateTime).Value = fechaConfig;
                bd.ejecutarConsultaDevuelveInt(procedure);
                //no chequeo si lo puede modificar xq ya lo hago antes
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Recorrido modificado correctamente");
        }
    }
}
