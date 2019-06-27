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
            llenardataGridView(dataGridRecorridosActuales, "SELECT id_recorrido,id_origen,id_destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
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
                if (result > 0) MessageBox.Show("Se eliminó el recorrido");
                else MessageBox.Show("No existe el recorrido");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                textoRecorridoSeleccionado.Text = dataGridRecorridosActuales.CurrentRow.Cells["id_recorrido"].Value.ToString();

                try
                {
                    bd.conectar();
                    SqlConnection conexion = bd.obtenerConexion();
                    string msg = "SELECT id_tramo,id_origen,id_destino,orden,precio_base FROM [LEISTE_EL_CODIGO?].Tramo WHERE @idRec = id_recorrido";
                    SqlCommand proc = new SqlCommand(msg, conexion);
                    proc.Parameters.Add("@idRec", SqlDbType.Decimal).Value = Convert.ToDecimal(dataGridRecorridosActuales.CurrentRow.Cells["id_recorrido"].Value);
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
                MessageBox.Show("no hay nada para mostrar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
