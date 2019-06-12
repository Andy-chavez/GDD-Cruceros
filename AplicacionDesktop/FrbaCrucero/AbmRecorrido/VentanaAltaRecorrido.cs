using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class VentanaAltaRecorrido : Form
    {
        public VentanaAltaRecorrido()
        {
            InitializeComponent();
        }

        private void VentanaAltaRecorrido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.Tramo' Puede moverla o quitarla según sea necesario.
            this.tramoTableAdapter.Fill(this.dataSet5.Tramo);
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramo.TramosDisponibles' Puede moverla o quitarla según sea necesario.
            this.tramosDisponiblesTableAdapter.Fill(this.dataSetTramo.TramosDisponibles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
           VentanaTramo ventana = new VentanaTramo();
           ventana.Show();
          
        }

        private void botonTramo_Click(object sender, EventArgs e)
        {
           VentanaTramo ventana = new VentanaTramo();
           ventana.Show();
           ventana.esconderBotonEliminar();
           
        }
    }
}
