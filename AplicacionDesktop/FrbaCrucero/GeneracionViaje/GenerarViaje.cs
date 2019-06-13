using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Data.SqlClient;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class GenerarViaje : Form
    {
        public GenerarViaje()
        {
            InitializeComponent();
            RecorridosDisp();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCruc_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crucerosDisponiblesParaViaje");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2).Value = this.dateTimePickerInicio.Value;
                procedure.Parameters.Add("@fecha_finalizacion_estimada", SqlDbType.DateTime2).Value = this.dateTimePickerFin.Value;
                dt = bd.obtenerDataTable(procedure);
                this.dataGridViewCruc.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void RecorridosDisp()
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("SELECT * FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
                //procedure.CommandType = CommandType.TableDirect;
                //procedure.Parameters.Add("@anio", SqlDbType.NVarChar).Value = this.comboBoxAnio.SelectedItem.ToString();
                //procedure.Parameters.Add("@semestre", SqlDbType.NVarChar).Value = this.comboBoxSemestre.SelectedItem.ToString();
                dt = bd.obtenerDataTable(procedure);
                this.dataGridViewRec.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonGenViaje_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataGridViewRow rowRec = this.dataGridViewRec.CurrentRow;//id_recorrido
                DataGridViewRow rowCruc = this.dataGridViewCruc.CurrentRow;

                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].cargarViaje");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@id_recorrido", SqlDbType.Decimal).Value = rowRec.Cells["id_recorrido"].Value;
                procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = rowCruc.Cells["id_crucero"].Value;
                procedure.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2).Value = this.dateTimePickerInicio.Value;
                procedure.Parameters.Add("@fecha_finalizacion_estimada", SqlDbType.DateTime2).Value = this.dateTimePickerFin.Value;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                switch (retorno)
                {
                    case 1:
                        MessageBox.Show("Viaje cargado correctamente");
                        break;
                    case -1:
                        MessageBox.Show("Fecha mal ingresada, se quiere generar viaje de fecha anterior a la actual");
                        break;
                    case -2:
                        MessageBox.Show("Crucero ocupado entre esas fechas");
                        break;
                    case -3:
                        MessageBox.Show("Recorrido inhabilitado");
                        break;
                    case -4:
                        MessageBox.Show("Crucero inhabilitado");
                        break;
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
