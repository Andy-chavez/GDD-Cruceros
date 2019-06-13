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
        private Rol rol = new Rol();
        SqlDataAdapter adapt;
        private void VentanaDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            listaFunc.DataSource = dt;
            listaFunc.ValueMember = "id_funcionalidad";
            bd.desconectar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposEstancompletos())
            {
                textoNombre.Enabled = false;
                //this.agregarRol();
                try
                {
                    BaseDeDato bd = new BaseDeDato();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearNuevoRol");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                    procedure.Parameters.Add("@idFuncionalidad", SqlDbType.NVarChar).Value = listaFunc.Text;
                    procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd.ejecutarConsultaDevuelveInt(procedure);
                    int retorno = (int)procedure.Parameters["@retorno"].Value;
                    if (retorno == 1) //joya
                    {
                        MessageBox.Show("Rol creado exitosamente, agregue nuevas funciones a dicho rol seleccionándolas de las posibles y presionando el boton crear. Presione limpiar si neceista crear un nuevo rol.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (retorno == -2) // no existe funcionalidad
                    { //no existe usuario
                        MessageBox.Show("No Existe dicha Funcionalidad.");
                    }
                    else if (retorno == -3) // el rol ya tiene esa funcionalidad
                    { //no existe usuario
                        MessageBox.Show("El nombre de rol ingresado ya posee la funcionalidad seleccionada.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void textoNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {


        }
        private void agregarRol()
        {
            if (textoNombre.Text != "")
            {

                rol.crearRol(textoNombre.Text, listaFunc.SelectedValue.ToString());

                DialogResult result = MessageBox.Show("Rol creado exitosamente, agregue nuevas funciones a dicho rol seleccionándolas de las posibles y presionando el boton crear. Presione limpiar si neceista crear un nuevo rol.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Nombre de rol vacío. Inserte el nombre del rol", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textoNombre.Clear();
            textoNombre.Enabled = true;
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

            return textoNombre.Text != "" && listaFunc.Text != "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
