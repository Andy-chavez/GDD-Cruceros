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

        private void viajesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaSeleccionarviaje_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(viajesDisponibles);
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
            this.filtrarDataGrdView(viajesDisponibles, "SELECT * FROM [LEISTE_EL_CODIGO?].Viaje WHERE fecha_inicio L ('" + textoFechaInicio.Text + "%')");
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
       
    }
}
