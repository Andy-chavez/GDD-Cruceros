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
using System.Data.SqlTypes;

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaCrearRol : Form
    {
        public VentanaCrearRol()
        {
            InitializeComponent();
        }
        private BaseDeDato bd = new BaseDeDato();
        private DataTable dt = new DataTable();
        private List<object> listaFuncion = new List<object>();
       // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        private void VentanaDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc1.DataSource = dt;
            listaFunc1.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc2.DataSource = dt;
            listaFunc2.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc3.DataSource = dt;
            listaFunc3.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc4.DataSource = dt;
            listaFunc4.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc5.DataSource = dt;
            listaFunc5.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc6.DataSource = dt;
            listaFunc6.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc7.DataSource = dt;
            listaFunc7.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc8.DataSource = dt;
            listaFunc8.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc9.DataSource = dt;
            listaFunc9.ValueMember = "id_funcionalidad";
            bd.desconectar();

            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc10.DataSource = dt;
            listaFunc10.ValueMember = "id_funcionalidad";
            bd.desconectar();
            vaciarFuncionalidades();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void vaciarFuncionalidades()
        {
            listaFunc10.SelectedItem = null;
            listaFunc10.SelectedText = "";
            listaFunc9.SelectedItem = null;
            listaFunc9.SelectedText = "";
            listaFunc8.SelectedItem = null;
            listaFunc8.SelectedText = "";
            listaFunc7.SelectedItem = null;
            listaFunc7.SelectedText = "";
            listaFunc6.SelectedItem = null;
            listaFunc6.SelectedItem = "";
            listaFunc5.SelectedItem = null;
            listaFunc5.SelectedItem = "";
            listaFunc4.SelectedItem = null;
            listaFunc4.SelectedItem = "";
            listaFunc3.SelectedItem = null;
            listaFunc3.SelectedText = "";
            listaFunc2.SelectedItem = null;
            listaFunc2.SelectedText = "";
            listaFunc1.SelectedItem = null;
            listaFunc1.SelectedText = "";

        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposEstancompletos())
            {
                textoNombre.Enabled = false;
                try
                {
                    BaseDeDato bd = new BaseDeDato();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearNuevoRol");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                    procedure.Parameters.Add("@idFuncionalidad1", SqlDbType.NVarChar).Value = listaFunc1.Text;
                    procedure.Parameters.Add("@idFuncionalidad2", SqlDbType.NVarChar).Value = listaFunc2.Text;
                    procedure.Parameters.Add("@idFuncionalidad3", SqlDbType.NVarChar).Value = listaFunc3.Text;
                    procedure.Parameters.Add("@idFuncionalidad4", SqlDbType.NVarChar).Value = listaFunc4.Text;
                    procedure.Parameters.Add("@idFuncionalidad5", SqlDbType.NVarChar).Value = listaFunc5.Text;
                    procedure.Parameters.Add("@idFuncionalidad6", SqlDbType.NVarChar).Value = listaFunc6.Text;
                    procedure.Parameters.Add("@idFuncionalidad7", SqlDbType.NVarChar).Value = listaFunc7.Text;
                    procedure.Parameters.Add("@idFuncionalidad8", SqlDbType.NVarChar).Value = listaFunc8.Text;
                    procedure.Parameters.Add("@idFuncionalidad9", SqlDbType.NVarChar).Value = listaFunc9.Text;
                    procedure.Parameters.Add("@idFuncionalidad10", SqlDbType.NVarChar).Value = listaFunc10.Text;
                    procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd.ejecutarConsultaDevuelveInt(procedure);
                    int retorno = (int)procedure.Parameters["@retorno"].Value;
                    if (retorno == 1) //joya
                    {
                        bd.desconectar();
                        MessageBox.Show("Rol creado exitosamente. \nAgregue nuevas funciones a dicho rol seleccionándolas de las posibles y presionando el boton crear.\nPresione limpiar si necesita crear un nuevo rol.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (retorno == -2) // no existe funcionalidad
                    {
                        bd.desconectar();
                        MessageBox.Show("No Existe dicha Funcionalidad.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    else if (retorno == -5) // el rol ya tiene esa funcionalidad
                    {
                        bd.desconectar();
                        MessageBox.Show("Error al cargar el rol.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (retorno == -4) // el rol ya tiene esa funcionalidad
                    {
                        bd.desconectar();
                        MessageBox.Show("El nombre de rol ingresado ya existe.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (retorno == -3) // el rol ya tiene esa funcionalidad
                    {
                        bd.desconectar();
                        MessageBox.Show("El nombre de rol ingresado ya posee la funcionalidad seleccionada.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete el nombre del rol y al menos una funcionalidad para continuar", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textoNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {


        }
        private void listaFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textoNombre.Clear();
            textoNombre.Enabled = true;
            vaciarFuncionalidades();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarItems(ComboBox cb)
        {

        }

        private void listaFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool todosLosCamposEstancompletos()
        {

            return textoNombre.Text != "" && (listaFunc1.SelectedText != "" || listaFunc2.SelectedText != "" ||
                listaFunc3.SelectedText != "" || listaFunc4.SelectedText != "" ||
                listaFunc5.SelectedText != "" || listaFunc6.SelectedText != "" ||
                listaFunc7.SelectedText != "" || listaFunc8.SelectedText != "" ||
                listaFunc9.SelectedText != "" || listaFunc10.SelectedText != "");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
