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
    public partial class VentanaModificarRecorrido : Form
    {
        public VentanaModificarRecorrido()
        {
            InitializeComponent();
        }

        private Recorrido recorrido = new Recorrido();
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();

        private void recorridosActuales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenardataGridView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand(nombreConsulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void VentanaModificarRecorrido_Load(object sender, EventArgs e)
        {
            llenardataGridView(recorridosActuales, "SELECT * FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
            llenarCombo(nuevoOrigen, "SELECT id_origen FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
            llenarCombo(nuevoDestino, "SELECT id_origen FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");

        }

        private void tramosDisponibles_CellContentClick()
        {

        }

        private void botonModificarRecorrido_Click(object sender, EventArgs e)
        {
            recorrido.modificarRecorrido(Convert.ToDecimal(textoRecorridoSeleccionado.Text), nuevoOrigen.Text.ToString(), nuevoDestino.Text.ToString());
        }

        private void botonDardeBaja_Click(object sender, EventArgs e)
        {
            recorrido.darDeBaja(Convert.ToDecimal(textoRecorridoSeleccionado.Text));
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
        public void esconderCosasModificar()
        {
            groupBox2.Hide();
            botonModificarRecorrido.Hide();
        }
        public void esconderCosasBaja()
        {
            botonDardeBaja.Hide();
        }
    }
}
