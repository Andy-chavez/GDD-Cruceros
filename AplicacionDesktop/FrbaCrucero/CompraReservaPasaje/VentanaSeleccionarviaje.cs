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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class VentanaSeleccionarviaje : Form
    {
        public VentanaSeleccionarviaje()
        {
            InitializeComponent();
        }

        public BaseDeDato bd = new BaseDeDato();
        public DataTable dt = new DataTable();
        

        #region DataGridView



        public void dataGridViewCargar(DataGridView dataGridView, DataSet vista)
        {
            dataGridView.DataSource = vista;
        }
      /*  public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlCommand command = bd.ejecutarConsulta("SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
        */
        public void dataGridViewAgregarBotonSeleccionar(DataGridView dataGridView)
        {
            DataGridViewButtonColumn botonSeleccion = new DataGridViewButtonColumn();
            botonSeleccion.HeaderText = "Seleccionar";
            botonSeleccion.Text = "Seleccionar";
            botonSeleccion.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(botonSeleccion);
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void VentanaSeleccionarviaje_Load(object sender, EventArgs e)
        {
            monthCalendar1.BringToFront();
            this.llenardataGridView(viajesDisponibles);
            this.llenarCombo(listaOrigen, "SELECT id_origen FROM [LEISTE_EL_CODIGO?].Tramo");
            this.llenarCombo(listaDestino, "SELECT id_destino FROM [LEISTE_EL_CODIGO?].Tramo");
        }
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].Viaje", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textoFechaInicio.Text = Convert.ToDateTime(monthCalendar1.SelectionStart).ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }

        private void textoFechaInicio_TextChanged(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(viajesDisponibles, "SELECT * FROM [LEISTE_EL_CODIGO?].Viaje WHERE fecha_inicio LIKE ('" + textoFechaInicio.Text + "%')");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

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

        private void viajesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viajesDisponibles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                viajesDisponibles.CurrentRow.Selected = true;

                int idTramo = Convert.ToInt32(viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                decimal id_recorrido = Convert.ToDecimal( viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                string id_crucero = viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString();
                DateTime fecha_inicio = Convert.ToDateTime( viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                DateTime fecha_finalizacion_estimada = Convert.ToDateTime(viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                DateTime fecha_finalizacion = Convert.ToDateTime(viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                Viaje viajeSeleccionado = new Viaje(idTramo,id_recorrido,id_crucero,fecha_inicio,fecha_finalizacion_estimada,fecha_finalizacion);

            }
            else
            {

                MessageBox.Show("No hay tramos para agregar", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void viajesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonReserva_Click(object sender, EventArgs e)
        {
           
        }
        public void llenarCombo(ComboBox cb, string consultaDeObtencion)
        {

            BaseDeDato db = new BaseDeDato();
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].Tramo", conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            cb.DataSource = listaDeTramos;
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();
        }

        private void listaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
