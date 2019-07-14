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
    public partial class VentanaDarDeBajaRecorrido : Form //es la ventana de eliminar recorrido en realidad
    {
        public VentanaDarDeBajaRecorrido()
        {
            InitializeComponent();
        }

        private Recorrido recorrido = new Recorrido();
        private BaseDeDato bd = new BaseDeDato();

        private void recorridosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenardataGridView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand(nombreConsulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void VentanaModificarRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(dataGridRecorridosActuales, "SELECT id_recorrido ID,id_origen Origen,id_destino Destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
            //llenarCombo(nuevoOrigen, "SELECT id_origen FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
            //llenarCombo(nuevoDestino, "SELECT id_destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");

        }

        private void tramosDisponibles_CellContentClick()
        {

        }

        private void botonModificarRecorrido_Click(object sender, EventArgs e)
        {/*
            if (nuevoOrigen.Text != nuevoDestino.Text)
            {
                recorrido.modificarRecorrido(Convert.ToDecimal(textoRecorridoSeleccionado.Text), nuevoOrigen.Text.ToString(), nuevoDestino.Text.ToString());
            }
            else {
                      MessageBox.Show("el origen y el destino deben ser distintos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
        private void botonDardeBaja_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darDeBajaRecorrido");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = Convert.ToDecimal(textoRecorridoSeleccionado.Text);
                int result = bd.ejecutarConsultaDevuelveInt(procedure);
                if (result > 0)
                {
                    MessageBox.Show("Se dió de baja el recorrido", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridTramos.DataSource = null;
                    VentanaModificarRecorrido_Load(null, null);
                }
                else MessageBox.Show("No existe el recorrido", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch
            {
                MessageBox.Show("Debe elegir un recorrido", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textoRecorridoSeleccionado_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuevoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarCombo(ComboBox cb, string consultaDeObtencion)
        {

            BaseDeDato db = new BaseDeDato();
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand(consultaDeObtencion, conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            cb.DataSource = listaDeTramos;
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();
        }

        private void nuevoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void esconderCosasBaja()
        {
            botonDardeBaja.Hide();
        }

        private void recorridosActuales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRecorridosActuales.CurrentRow.Cells[0].Value != null)
            {
                dataGridRecorridosActuales.CurrentRow.Selected = true;

                textoRecorridoSeleccionado.Text = dataGridRecorridosActuales.CurrentRow.Cells["ID"].Value.ToString();

                try
                {
                    bd.conectar();
                    SqlConnection conexion = bd.obtenerConexion();
                    string msg = "SELECT id_origen Origen,id_destino Destino,precio_base Precio FROM [LEISTE_EL_CODIGO?].Tramo WHERE @idRec = id_recorrido order by orden asc";
                    SqlCommand proc = new SqlCommand(msg, conexion);
                    proc.Parameters.Add("@idRec", SqlDbType.Decimal).Value = Convert.ToDecimal(dataGridRecorridosActuales.CurrentRow.Cells["ID"].Value);
                    SqlDataAdapter adapter = new SqlDataAdapter(proc);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridTramos.DataSource = dt;
                    bd.desconectar();
                }
                catch(Exception ex)
                {
                    bd.desconectar();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay nada para mostrar ", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            //nuevoOrigen.SelectedIndex = -1;
            //nuevoDestino.SelectedIndex = -1;
            textoRecorridoSeleccionado.Clear();
        }

        public void esconderBaja()
        {
            botonDardeBaja.Hide();
        }

        private void filtrarDataGrdView(DataGridView dgv, string nombreConsulta)
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

        private void buttonFiltrarRecs_Click(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(dataGridRecorridosActuales,
                "SELECT id_recorrido ID,id_origen Origen,id_destino Destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles WHERE id_origen LIKE ('" + this.textBoxFiltroOrigen.Text + "%') AND id_destino LIKE ('" + this.textBoxFiltroDestino.Text + "%')");
        }

        private void buttonLimpiarRecs_Click(object sender, EventArgs e)
        {
            this.textBoxFiltroDestino.Text = "";
            this.textBoxFiltroOrigen.Text = "";
            this.textoRecorridoSeleccionado.Text = "";
            VentanaModificarRecorrido_Load(null, null);
            this.dataGridTramos.DataSource = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
