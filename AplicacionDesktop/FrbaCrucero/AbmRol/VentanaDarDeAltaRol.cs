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
    public partial class VentanaDarDeAltaRol : Form
    {
        BaseDeDato bd = new BaseDeDato();
        SqlDataAdapter adapt;
        DataTable dt;
        public VentanaDarDeAltaRol()
        {
            InitializeComponent();
        }
        private void VentanaDarDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.desconectar();
        }

        private void BotonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAlta_Click_1(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darAltaRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = comboBoxRoles.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Rol habilitado correctamente");
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
    }
}
