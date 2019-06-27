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
using System.Configuration;

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaModificarRol : Form
    {
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
        private String id;
       // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        public VentanaModificarRol(string idRol)
        {
            InitializeComponent();
            this.llenardataGridView(listaFunc); 
            this.id = idRol;
            rolSelect.Text = idRol;
            rolSelect.Enabled = false;
            this.llenarFuncionalidades(idRol);
            this.llenarNoFuncionalidades(idRol);
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
        {
        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].eliminarFuncionalidadRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = this.id;
                procedure.Parameters.Add("@idFuncionalidadAEliminar", SqlDbType.NVarChar).Value = comboBoxFuncionalidades.Text;
                procedure.Parameters.Add("@nuevoNombreRol", SqlDbType.NVarChar).Value = casillaUsuario.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Operacion completada correctamente", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = this.id;
                procedure.Parameters.Add("@idNuevaFuncionalidad", SqlDbType.NVarChar).Value = comboBoxFuncAgregar.Text;
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

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void llenarNoFuncionalidades(string idRol)
        {
            SqlConnection con = new SqlConnection(bd.getConfig());
            con.Open();
            SqlCommand cmd = new SqlCommand();

            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@idRol";

            parameter.SqlDbType = SqlDbType.NVarChar;

            parameter.Direction = ParameterDirection.Input;

            parameter.Value = idRol;
            cmd.Connection = con;
            string sqlCmd = @"SELECT distinct id_funcionalidad FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_funcionalidad not in (select id_funcionalidad
		FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_rol like @idRol)";
            cmd.CommandText = sqlCmd;

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRol", idRol);

            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboBoxFuncAgregar.ValueMember = "id_funcionalidad";
            comboBoxFuncAgregar.DataSource = dt;
        }
        private void llenarFuncionalidades(string idRol)
        {
            SqlConnection con = new SqlConnection(bd.getConfig());
            con.Open();
            SqlCommand cmd = new SqlCommand();

            SqlParameter parameter = new SqlParameter();

            parameter.ParameterName = "@idRol";

            parameter.SqlDbType = SqlDbType.NVarChar;

            parameter.Direction = ParameterDirection.Input;

            parameter.Value = idRol;
            cmd.Connection = con;
            string sqlCmd = @"SELECT id_funcionalidad FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_rol = @idRol";
            cmd.CommandText = sqlCmd;

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRol", idRol);

            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboBoxFuncionalidades.ValueMember = "id_funcionalidad";
            comboBoxFuncionalidades.DataSource = dt;
        }

        private void RolSelect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
