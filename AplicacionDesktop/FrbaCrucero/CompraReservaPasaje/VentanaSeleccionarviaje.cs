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
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlCommand command = bd.ejecutarConsulta("SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

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
    }
}
