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

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaDarBajaRol : Form
    {
        public VentanaDarBajaRol()
        {
            InitializeComponent();
        }
        BaseDeDato bd = new BaseDeDato();
        SqlDataAdapter adapt;
        DataTable dt;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaModificarRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.desconectar();

        }
        public void botonEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darBajaRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = comboBoxRoles.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Operacion completada correctamente", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                }
                else if (retorno == -1) // no existe el rol
                { //no existe usuario
                    MessageBox.Show("No Existe el Rol");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
