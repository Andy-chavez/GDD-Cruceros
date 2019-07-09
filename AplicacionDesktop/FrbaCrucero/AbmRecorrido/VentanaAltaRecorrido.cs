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
            SetDefaults();
        }

        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<Tramo> listaTramos = new List<Tramo>();
        private List<string> listaCiudades = new List<string>();

        void SetDefaults()
        {
            this.dataGridTramos.ColumnCount = 3;
            this.dataGridTramos.Columns[0].Name = "Origen";
            this.dataGridTramos.Columns[1].Name = "Destino";
            this.dataGridTramos.Columns[2].Name = "Precio";
            this.dataGridTramos.EditingControlShowing += dataGridTramos_EditingControlShowing;
            this.dataGridTramos.Columns[0].ReadOnly = true;
            this.dataGridTramos.Columns[1].ReadOnly = true;
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
            if(this.dataGridTramos.CurrentRow.Cells["Origen"].Value.ToString()==""
                || this.dataGridTramos.CurrentRow.Cells["Destino"].Value.ToString() == "")
            {
                e.Handled = true;
                return;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
                 &&!(e.KeyChar==',' && !this.dataGridTramos.CurrentRow.Cells["Precio"].EditedFormattedValue.ToString().Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void VentanaAltaRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(dataGridPuertos);
        }

        private void listaDeTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT id_puerto Puerto FROM [LEISTE_EL_CODIGO?].Puerto order by id_puerto", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }


        //private void botonEliminar_Click(object sender, EventArgs e)
        //{
        //    VentanaBorrarTramo ventana = new VentanaBorrarTramo();
        //    ventana.Show();

        //}

        //int orden = 1;

        private void botonSacarTramo_Click(object sender, EventArgs e)
        {
            int indice = this.dataGridTramos.Rows.Count - 1;
            if (indice == -1) return;

            if (this.dataGridTramos.Rows[indice].Cells["Origen"].Value.ToString() != "")
            {

                if (this.dataGridTramos.Rows.Count > 1)
                {
                    this.dataGridTramos.Rows[indice-1].Cells["Destino"].Value = "";
                    this.dataGridTramos.Rows[indice-1].Cells["Precio"].Value = "";
                    this.dataGridTramos.Rows.RemoveAt(indice);
                }
                else
                {
                    this.dataGridTramos.Rows[indice].Cells["Origen"].Value = "";
                    this.dataGridTramos.Rows[indice].Cells["Precio"].Value = "";
                }
            }            
        }

        private void botonTramo_Click(object sender, EventArgs e)
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
                if(this.dataGridTramos.Rows[indice].Cells["Origen"].Value.ToString()== puerto)
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

        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (this.dataGridTramos.Rows.Count == 1)
            {
                MessageBox.Show("Debe ingresar al menos un origen y un destino");
                return;
            }

            string primerOrigen = this.dataGridTramos.Rows[0].Cells["Origen"].Value.ToString();
            string ultimoDestino = this.dataGridTramos.Rows[this.dataGridTramos.Rows.Count-1].Cells["Origen"].Value.ToString();//fue el ultimo destino

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
                    procedure.Parameters.Add("@orden", SqlDbType.SmallInt).Value = Convert.ToInt16(i+1);
                    procedure.Parameters.Add("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(this.dataGridTramos.Rows[i].Cells["Precio"].Value.ToString());
                    procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd.ejecutarConsultaDevuelveInt(procedure);
                    int result = Convert.ToInt32(procedure.Parameters["@retorno"].Value);
                    switch (result)
                    {
                        case 1:
                            break;
                        case -1:
                            MessageBox.Show("El origen y destino del tramo " + i + " son el mismo");
                            BajarRecFallido(idRec);
                            return;
                        case -2:
                            MessageBox.Show("El origen del tramo " + i + " no coincide con el destino del tramo anterior");
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
                    BajarRecFallido(idRec);
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

        private void filtroOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (filtroOrigen.Text.Length == 0) return;
            this.filtrarDataGrdView(dataGridPuertos, "SELECT id_puerto Puerto FROM [LEISTE_EL_CODIGO?].Puerto WHERE id_puerto LIKE ('" + filtroOrigen.Text + "%') order by id_puerto");

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

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            filtroOrigen.Clear();
            llenardataGridView(dataGridPuertos);
        }
        public void filtrarDataGrdView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlCommand consulta = new SqlCommand(nombreConsulta, bd.obtenerConexion());
            DataTable tabla = bd.obtenerDataTable(consulta);
            //SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            //adapter.Fill(tabla);
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

        private void DataGridTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
