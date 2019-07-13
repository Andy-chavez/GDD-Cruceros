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
        //private List<Tramo> listaTramos = new List<Tramo>();
        //int orden = 1;
        decimal idRec=-1;
        private DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);

        public TrueModificarRecorrido()
        {
            InitializeComponent();
            SetDefaults();
            this.dataGridRecorridosActuales.CellClick += dataGridRecorridosActuales_CellContentClick;
        }

        void SetDefaults()
        {
            this.dataGridTramos.ColumnCount = 3;
            this.dataGridTramos.Columns[0].Name = "Origen";
            this.dataGridTramos.Columns[1].Name = "Destino";
            this.dataGridTramos.Columns[2].Name = "Precio";
            this.dataGridTramos.EditingControlShowing += dataGridTramos_EditingControlShowing;
            this.dataGridTramos.Columns[0].ReadOnly = true;
            this.dataGridTramos.Columns[1].ReadOnly = true;
            this.textBoxFiltroOrigen.Text = "";
            this.textBoxFiltroDestino.Text = "";
        }

        private void dataGridTramos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridTramos.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridTramos.CurrentRow.Cells["Origen"].Value.ToString() == ""
                || this.dataGridTramos.CurrentRow.Cells["Destino"].Value.ToString() == "")
            {
                e.Handled = true;
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && !(e.KeyChar == ',' && !this.dataGridTramos.CurrentRow.Cells["Precio"].EditedFormattedValue.ToString().Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void TrueModificarRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(dataGridRecorridosActuales, "SELECT id_recorrido ID,id_origen Origen,id_destino Destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
        }
        public void llenardataGridView(DataGridView dgv,string msg)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand(msg, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = null;
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void dataGridRecorridosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textoRecorridoSeleccionado.Text = dataGridRecorridosActuales.CurrentRow.Cells["ID"].Value.ToString();

            idRec = Convert.ToDecimal(dataGridRecorridosActuales.CurrentRow.Cells["ID"].Value);

            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            string msg = "SELECT id_origen Origen,id_destino Destino,precio_base Precio FROM [LEISTE_EL_CODIGO?].Tramo WHERE @idRec = id_recorrido order by orden ASC";
            SqlCommand proc = new SqlCommand(msg, conexion);
            proc.Parameters.Add("@idRec", SqlDbType.Decimal).Value = Convert.ToDecimal(dataGridRecorridosActuales.CurrentRow.Cells["ID"].Value);
            SqlDataAdapter adapter = new SqlDataAdapter(proc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridTramosRecOrig.DataSource = null;
            dataGridTramosRecOrig.DataSource = dt;
            bd.desconectar();

            llenardataGridView(dataGridPuertos, "SELECT id_puerto Puerto FROM [LEISTE_EL_CODIGO?].Puerto");

            this.dataGridTramos.Rows.Clear();
            this.dataGridTramos.Refresh();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            filtroOrigen.Clear();
            //textoRecorridoSeleccionado.Clear();
            llenardataGridView(dataGridPuertos, "SELECT id_puerto Puerto FROM [LEISTE_EL_CODIGO?].Puerto");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(dataGridPuertos, "SELECT id_puerto Puerto FROM [LEISTE_EL_CODIGO?].Puerto WHERE id_puerto LIKE ('" + filtroOrigen.Text + "%')");
        }
        public void filtrarDataGrdView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlCommand consulta = new SqlCommand(nombreConsulta, bd.obtenerConexion());
            DataTable tabla = bd.obtenerDataTable(consulta);
            //SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            //adapter.Fill(tabla);
            dgv.DataSource = null;
            dgv.DataSource = tabla;
            bd.desconectar();
        }

        private void buttonAddTramo_Click(object sender, EventArgs e)
        {
            if (this.dataGridPuertos.CurrentRow == null) return;
            if (this.dataGridPuertos.CurrentRow.Cells[0] == null) return;

            string puerto = this.dataGridPuertos.CurrentRow.Cells["Puerto"].Value.ToString();

            int indice = this.dataGridTramos.Rows.Count - 1;

            if (indice == -1)
            {
                this.dataGridTramos.Rows.Add(puerto, "", "");
                //orden++;
            }
            else
            {
                if (this.dataGridTramos.Rows[indice].Cells["Origen"].Value.ToString() == puerto)
                {
                    MessageBox.Show("El origen no puede ser igual al destino", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.dataGridTramos.Rows[indice].Cells["Origen"].Value.ToString() == "")
                {
                    this.dataGridTramos.Rows[indice].Cells["Origen"].Value = puerto;
                }
                else
                {
                    this.dataGridTramos.Rows[indice].Cells["Destino"].Value = puerto;
                    this.dataGridTramos.Rows.Add(puerto, "", "");
                }
                //orden++;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrarLastTramo_Click(object sender, EventArgs e)
        {
            int indice = this.dataGridTramos.Rows.Count - 1;
            if (indice == -1) return;

            if (this.dataGridTramos.Rows[indice].Cells["Origen"].Value.ToString() != "")
            {

                if (this.dataGridTramos.Rows.Count > 1)
                {
                    this.dataGridTramos.Rows[indice - 1].Cells["Destino"].Value = "";
                    this.dataGridTramos.Rows[indice - 1].Cells["Precio"].Value = "";
                    this.dataGridTramos.Rows.RemoveAt(indice);
                }
                else
                {
                    this.dataGridTramos.Rows[indice].Cells["Origen"].Value = "";
                    this.dataGridTramos.Rows[indice].Cells["Precio"].Value = "";
                }
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (idRec < 0)
            {
                MessageBox.Show("Primero elija el recorrido a modificar");
                return;
            }

            if (this.dataGridTramos.Rows.Count == 1 || this.dataGridTramos.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un origen y un destino");
                return;
            }

            string primerOrigen = this.dataGridTramos.Rows[0].Cells["Origen"].Value.ToString();
            string ultimoDestino = this.dataGridTramos.Rows[this.dataGridTramos.Rows.Count - 1].Cells["Origen"].Value.ToString();//fue el ultimo destino

            //check que todos los precios ten cargados y sean validos decimal
            for (int i = 0; i < this.dataGridTramos.Rows.Count - 1; i++)
            {
                decimal testval;
                if (!Decimal.TryParse(this.dataGridTramos.Rows[i].Cells["Precio"].Value.ToString(), out testval))
                {
                    MessageBox.Show("El precio de la fila " + (i + 1) + " es invalido");
                    return;
                }
                decimal limit = 0.0099999999999999999999999999m;
                if (testval <= limit)
                {
                    MessageBox.Show("El precio de la fila " + (i + 1) + " es menor o igual a 0,00");
                    return;
                }
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
            for (int i = 0; i < this.dataGridTramos.Rows.Count - 1; i++)
            {
                try
                {
                    BaseDeDato bd = new BaseDeDato();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearTramo");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = idRec;
                    procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = this.dataGridTramos.Rows[i].Cells["Origen"].Value.ToString();
                    procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = this.dataGridTramos.Rows[i].Cells["Destino"].Value.ToString();
                    procedure.Parameters.Add("@orden", SqlDbType.SmallInt).Value = Convert.ToInt16(i + 1);
                    procedure.Parameters.Add("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(this.dataGridTramos.Rows[i].Cells["Precio"].Value.ToString());
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
            catch
            {
                MessageBox.Show("No se pudo modificar el recorrido", "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Recorrido modificado correctamente");
            TrueModificarRecorrido_Load(null, null);
            this.dataGridTramosRecOrig.DataSource = null;
            this.textoRecorridoSeleccionado.Text = "";
            botonLimpiar_Click(null, null);
            this.dataGridTramos.Rows.Clear();
            this.dataGridTramos.Refresh();
            this.textBoxFiltroDestino.Text = "";
            this.textBoxFiltroOrigen.Text = "";
        }

        private void buttonFiltrarRecs_Click(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(dataGridRecorridosActuales,
                "SELECT id_recorrido ID,id_origen Origen,id_destino Destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles WHERE id_origen LIKE ('" + this.textBoxFiltroOrigen.Text + "%') AND id_destino LIKE ('"+this.textBoxFiltroDestino.Text+ "%')");
        }

        private void buttonLimpiarRecs_Click(object sender, EventArgs e)
        {
            this.textBoxFiltroDestino.Text = "";
            this.textBoxFiltroOrigen.Text = "";
            TrueModificarRecorrido_Load(null, null);
            this.dataGridTramosRecOrig.DataSource = null;
        }

        private void DataGridTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
