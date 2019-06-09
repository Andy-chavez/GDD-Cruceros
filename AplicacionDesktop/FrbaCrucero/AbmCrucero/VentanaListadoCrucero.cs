using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero;
using FrbaCrucero.Clases;
using System.Data.SqlClient;

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaListadoCrucero : Form
    {

        public VentanaListadoCrucero()
        {
            InitializeComponent();

        }


        #region DataGridView

        

        public void dataGridViewCargar(DataGridView dataGridView, DataSet vista)
        {
            dataGridView.DataSource = vista;
        }

     /*   public static void dataGridViewAgregarBoton(DataGridView dataGridView, string textoBoton)
        {
            DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            botonModificar.HeaderText = "Accion";
            botonModificar.Text = textoBoton;
            botonModificar.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(botonModificar);
        }
*/
       
       /* public static void dataGridViewAgregarBotonAgregar(DataGridView dataGridView)
        {
            VentanaBase.dataGridViewAgregarBoton(dataGridView, "         Agregar         ");
        } */

        #endregion

        /* public DataView crucerosDisponibles();

        private BaseDeDato baseDeDato = new BaseDeDato();
        baseDeDato.crearConsulta(string consulta); */


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void filtro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void filtro1_TextChanged(object sender, EventArgs e)
        {

        }

        private void filtro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calendario_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            rsFiltro2.Text = Convert.ToDateTime(monthCalendar1.SelectionStart).ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void rsFiltro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            rsFiltro2.Text = Convert.ToDateTime(monthCalendar1.SelectionStart).ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void planillaDeResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaListado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CrucerosDisponibles' Puede moverla o quitarla según sea necesario.
            this.crucerosDisponiblesTableAdapter.Fill(this.dataSet1.CrucerosDisponibles);
          
        }
    }
}
