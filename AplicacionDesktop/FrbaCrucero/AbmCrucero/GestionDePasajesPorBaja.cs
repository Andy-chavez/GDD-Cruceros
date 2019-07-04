using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Clases;

namespace FrbaCrucero.AbmCrucero
{
    public partial class GestionDePasajesPorBaja : Form
    {
        public string fechaConfig = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];
        private string idCrucero;
        private BaseDeDato db = new BaseDeDato();
        public GestionDePasajesPorBaja(string id)
        {
            InitializeComponent();
            idCrucero = id;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e) //reemplazar reemplazarViajesCruceroPorOtro(@id_crucero nvarchar(50))
        {
            try
            {
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].reemplazarViajesCruceroPorOtro");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = this.idCrucero;
                db.ejecutarConsultaSinResultado(procedure);
                MessageBox.Show("Operacion completada con exito.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DiasCorrimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonPosponer_Click(object sender, EventArgs e)//posponer  diasCorrimiento posponerPasajes(@id_crucero nvarchar(50),@diasCorrimiento int)
        {
            try
            {
                if (diasCorrimiento.Text != "")
                {
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].posponerPasajes");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = this.idCrucero;
                    procedure.Parameters.AddWithValue("@diasCorrimiento", SqlDbType.Int).Value = int.Parse(diasCorrimiento.Text.ToString());
                    db.ejecutarConsultaSinResultado(procedure);
                    MessageBox.Show("Operacion completada con exito.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void esconderCosasDefinitiva()
        {
            groupBox2.Hide();
        }
        public void esconderCosasTemporal()
        {
            groupBox3.Hide();
        }
        private void Button2_Click(object sender, EventArgs e)//cancelar motivo cancelarPasajes(@id_crucero nvarchar(50),@fecha_actual datetime2,@motivo varchar(256))
        {
            try
            {
                if (motivo.Text != "")
                {
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].cancelarPasajes");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = this.idCrucero;
                    DateTime enteredDate = DateTime.Parse(fechaConfig);
                    procedure.Parameters.AddWithValue("@fecha_actual", SqlDbType.DateTime).Value = enteredDate;
                    procedure.Parameters.Add("@motivo", SqlDbType.VarChar).Value = motivo.Text;
                    db.ejecutarConsultaSinResultado(procedure);
                    MessageBox.Show("Operacion completada con exito.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
