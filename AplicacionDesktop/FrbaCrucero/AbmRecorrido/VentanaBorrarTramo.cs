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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class VentanaBorrarTramo : Form
    {
        public VentanaBorrarTramo()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand sel = Clases.BaseDeDato.crearConsulta("SELECT * FROM [LEISTE_EL_CODIGO?].Tramo");
                dt = bd.obtenerDataTable(sel);
                dataGridTramos.DataSource = dt;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataGridViewRow rowTramo = dataGridTramos.CurrentRow;

                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarTramo");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@id_tramo", SqlDbType.SmallInt).Value = Convert.ToInt16(rowTramo.Cells["id_tramo"].Value);
                int result=bd.ejecutarConsultaDevuelveInt(procedure);
                if (result > 0)
                {
                    MessageBox.Show("Tramo eliminado");
                }
                else MessageBox.Show("El tramo no existia");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
