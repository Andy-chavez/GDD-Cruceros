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
        public DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);
        public GenerarViaje()
        {
            InitializeComponent();
            RecorridosDisp();
            SetDefaults();
            this.dataGridViewRec.CellClick += dataGridViewRec_CellContentClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SetDefaults()
        {
            this.dateTimePickerInicio.MinDate = fechaConfig;
            this.dateTimePickerInicio.Value = fechaConfig;
            this.dateTimePickerFin.MinDate = fechaConfig;
            this.dateTimePickerFin.Value = fechaConfig;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BaseDeDato bd = new BaseDeDato();
            try
            {
                bd.conectar();
                SqlConnection conexion = bd.obtenerConexion();
                string msg = "SELECT id_origen Origen,id_destino Destino,precio_base Precio FROM [LEISTE_EL_CODIGO?].Tramo WHERE @idRec = id_recorrido order by orden asc";
                SqlCommand proc = new SqlCommand(msg, conexion);
                proc.Parameters.Add("@idRec", SqlDbType.Decimal).Value = Convert.ToDecimal(dataGridViewRec.CurrentRow.Cells["ID"].Value);
                SqlDataAdapter adapter = new SqlDataAdapter(proc);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridTramos.DataSource = dt;
                bd.desconectar();
            }
            catch (Exception ex)
            {
                bd.desconectar();
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCruc_Click(object sender, EventArgs e)
        {
            int ret = DateTime.Compare(this.dateTimePickerInicio.Value, this.dateTimePickerFin.Value);
            if (ret == 0)
            {
                MessageBox.Show("La fecha de inicio y fin son iguales", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ret > 0)
            {
                MessageBox.Show("La fecha de inicio es mayor a la de fin", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("SELECT id_recorrido ID, id_origen Origen, id_destino Destino FROM [LEISTE_EL_CODIGO?].RecorridosDisponibles");
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

                int ret = DateTime.Compare(this.dateTimePickerInicio.Value,this.dateTimePickerFin.Value);
                if (ret == 0)
                {
                    MessageBox.Show("La fecha de inicio y fin son iguales", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }else if (ret > 0)
                {
                    MessageBox.Show("La fecha de inicio es mayor a la de fin", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].cargarViaje");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@id_recorrido", SqlDbType.Decimal).Value = rowRec.Cells["ID"].Value;
                procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = rowCruc.Cells["id_crucero"].Value;
                procedure.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2).Value = this.dateTimePickerInicio.Value;
                procedure.Parameters.Add("@fecha_finalizacion_estimada", SqlDbType.DateTime2).Value = this.dateTimePickerFin.Value;
                procedure.Parameters.Add("@fechaConfig", SqlDbType.DateTime).Value = this.fechaConfig;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                switch (retorno)
                {
                    case 1:
                        MessageBox.Show("Viaje cargado correctamente", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case -1:
                        MessageBox.Show("Fecha mal ingresada, se quiere generar viaje de fecha anterior a la actual", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -2:
                        MessageBox.Show("Crucero ocupado entre esas fechas", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -3:
                        MessageBox.Show("Recorrido inhabilitado", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -4:
                        MessageBox.Show("Crucero inhabilitado", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }catch(Exception exception)
            {
                MessageBox.Show("Primero seleccione el recorrido y el crucero", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarViaje_Load(object sender, EventArgs e)
        {

        }

        private void DataGridViewCruc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
