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

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void comboBoxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void SetDefaults()
        {
            this.comboBoxAnio.SelectedIndex = 0;
            this.comboBoxSemestre.SelectedIndex = 0;
        }

        private void top5_rec_pasajes_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].topRecorridosConMasPasajesComprados");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@anio", SqlDbType.NVarChar).Value = this.comboBoxAnio.SelectedItem.ToString();
                procedure.Parameters.Add("@semestre", SqlDbType.NVarChar).Value = this.comboBoxSemestre.SelectedItem.ToString();
                dt = bd.obtenerDataTable(procedure);
                this.dataGridViewTop5s.DataSource = dt;
                this.dataGridViewTop5s.Refresh();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].topMasCabinasLibres");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@anio", SqlDbType.NVarChar).Value = this.comboBoxAnio.SelectedItem.ToString();
                procedure.Parameters.Add("@semestre", SqlDbType.NVarChar).Value = this.comboBoxSemestre.SelectedItem.ToString();
                dt = bd.obtenerDataTable(procedure);
                this.dataGridViewTop5s.DataSource = dt;
                this.dataGridViewTop5s.Refresh();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void top5cruc_fuera_serv_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].topCrucerosFueraDeServicio");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@anio", SqlDbType.NVarChar).Value = this.comboBoxAnio.SelectedItem.ToString();
                procedure.Parameters.Add("@semestre", SqlDbType.NVarChar).Value = this.comboBoxSemestre.SelectedItem.ToString();
                dt = bd.obtenerDataTable(procedure);
                this.dataGridViewTop5s.DataSource = dt;
                this.dataGridViewTop5s.Refresh();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
