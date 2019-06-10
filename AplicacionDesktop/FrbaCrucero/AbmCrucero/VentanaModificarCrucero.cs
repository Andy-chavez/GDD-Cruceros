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

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaModificarCrucero : VentanaListadoCrucero
    {




        public VentanaModificarCrucero()
        {
            InitializeComponent();


        }



        

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

        protected new void botonSeleccionar_Click(object sender, EventArgs e)
        {
            new VentanaDeAltaCrucero();
        }
        private void botonSeleccion_Click(object sender, EventArgs e)
        {
            
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
        { }
       

        private void rsFiltro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
           
        }

        private void planillaDeResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.botonSeleccion_Click(sender,e);
        }

        private void VentanaListado_Load(object sender, EventArgs e)
        {
           
         this.dataGridViewAgregarBotonSeleccionar(planillaDeResultados); 

        }
        public void dataGridViewAgregarBotonSeleccionar(DataGridView dataGridView)
        {
            DataGridViewButtonColumn botonSeleccion = new DataGridViewButtonColumn();
            botonSeleccion.HeaderText = "Seleccionar";
            botonSeleccion.Text = "Seleccionar";
            botonSeleccion.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(botonSeleccion);
        }
    }
}
