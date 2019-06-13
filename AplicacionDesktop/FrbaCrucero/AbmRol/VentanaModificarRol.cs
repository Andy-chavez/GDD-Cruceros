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

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaModificarRol : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
        private Rol rol = new Rol();
        SqlDataAdapter adapt;
        public VentanaModificarRol()
        {
            InitializeComponent();
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(listaFunc);
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxFuncionalidades.DataSource = dt;
            comboBoxFuncionalidades.ValueMember = "id_funcionalidad";
            bd.desconectar();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarFuncionalidadRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = comboBoxRoles.Text;
                procedure.Parameters.Add("@idFuncionalidadAEliminar", SqlDbType.NVarChar).Value = comboBoxFuncionalidades.Text;
                procedure.Parameters.Add("@nuevoNombreRol", SqlDbType.NVarChar).Value = casillaUsuario.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    VentanaMenu menu = new VentanaMenu();
                    this.Hide();
                }
                else if(retorno == -1) // no existe el rol
                { //no existe usuario
                    MessageBox.Show("No Existe el Rol");
                }
                else if (retorno == -2) //-2: No existe funcionalidad
                { //no existe usuario
                    MessageBox.Show("No Existe dicha funcionalidad");
                }
                else if (retorno == -3) //el rol ya tiene esa funcionalidad(agregar) o no tiene esa funcionalidad(eliminar)
                { //no existe usuario
                    MessageBox.Show("El rol seleccionado no tiene dicha funcionalidad");
                }
                //this.Hide();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void listaFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TextoRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CasillaUsuario_TextChanged(object sender, EventArgs e)
        {
            //casilaUsuario.Text()
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].agregarFuncionalidadPorRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = comboBoxRoles.Text;
                procedure.Parameters.Add("@idNuevaFuncionalidad", SqlDbType.NVarChar).Value = comboBoxFuncionalidades.Text;
                procedure.Parameters.Add("@nuevoNombreRol", SqlDbType.NVarChar).Value = casillaUsuario.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    VentanaMenu menu = new VentanaMenu();
                    this.Hide();
                }
                else if (retorno == -1) // no existe el rol
                { //no existe usuario
                    MessageBox.Show("No Existe el Rol");
                }
                else if (retorno == -2) //-2: No existe funcionalidad
                { //no existe usuario
                    MessageBox.Show("No Existe dicha Funcionalidad");
                }
                else if (retorno == -3) //el rol ya tiene esa funcionalidad(agregar) o no tiene esa funcionalidad(eliminar)
                { //no existe usuario
                    MessageBox.Show("El rol seleccionado ya tiene dicha funcionalidad");
                }
                //this.Hide();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
