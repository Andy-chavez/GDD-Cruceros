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
       // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        public VentanaModificarRol()
        {
            InitializeComponent();
            this.llenardataGridView(listaFunc);
            this.llenarRoles();
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
        {


            /*            bd.conectar();
                        adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
                        dt = new DataTable();
                        adapt.Fill(dt);
                        comboBoxFuncionalidades.DataSource = dt;
                        comboBoxFuncionalidades.ValueMember = "id_funcionalidad";
                        bd.desconectar();*/
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
        private void llenarRoles()
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].RolesHabilitados", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.desconectar();
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

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void llenarFuncionalidades(string idRol)
        {
            bd.desconectar();
            SqlConnection con = new SqlConnection(bd.getConfig());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT id_funcionalidad FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_rol = '@idRol'";
            cmd.Parameters.AddWithValue("@idRol", idRol);
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboBoxFuncionalidades.ValueMember = "id_funcionalidad";
            comboBoxFuncionalidades.DisplayMember = "id_funcionalidad";
            comboBoxFuncionalidades.DataSource = dt;
            /*
            cmd.CommandType = CommandType.Text;
            
            
            DataTable objDs = new DataTable();*/
            //conexion.Open();
            //adapt = new SqlDataAdapter(cmd);
            //adapt.Fill(objDs);
            //dt = new DataTable();
            //adapt.Fill(dt);
            // comboBoxFuncionalidades.DisplayMember = "id_rol";
            //bd.desconectar();
        }
private void ComboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoles.SelectedText.ToString() != "System.Data.DataRowView" || comboBoxRoles.SelectedText.ToString() != "")
            {
                string idRol = comboBoxRoles.SelectedValue.ToString();
                llenarFuncionalidades(idRol);
            }
            comboBoxFuncionalidades.Enabled = false;
            comboBoxFuncAgregar.Enabled = false;

            //comboBoxFuncionalidades. = 0;
        }
    }
}
