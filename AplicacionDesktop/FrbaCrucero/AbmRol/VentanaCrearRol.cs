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
        private int posicion = 0;
        private List<String> funcionalidadesParaRol = new List<string>() { "", "", "", "", "", "", "", "", "", "" };
       // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        private void VentanaDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridFuncionalidades.DataSource = dt;
            bd.desconectar();
            vaciarFuncionalidades();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void vaciarFuncionalidades()
        {

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
                    procedure.Parameters.Add("@idFuncionalidad1", SqlDbType.NVarChar).Value = funcionalidadesParaRol[0];
                    procedure.Parameters.Add("@idFuncionalidad2", SqlDbType.NVarChar).Value = funcionalidadesParaRol[1];
                    procedure.Parameters.Add("@idFuncionalidad3", SqlDbType.NVarChar).Value = funcionalidadesParaRol[2];
                    procedure.Parameters.Add("@idFuncionalidad4", SqlDbType.NVarChar).Value = funcionalidadesParaRol[3];
                    procedure.Parameters.Add("@idFuncionalidad5", SqlDbType.NVarChar).Value = funcionalidadesParaRol[4];
                    procedure.Parameters.Add("@idFuncionalidad6", SqlDbType.NVarChar).Value = funcionalidadesParaRol[5];
                    procedure.Parameters.Add("@idFuncionalidad7", SqlDbType.NVarChar).Value = funcionalidadesParaRol[6];
                    procedure.Parameters.Add("@idFuncionalidad8", SqlDbType.NVarChar).Value = funcionalidadesParaRol[7];
                    procedure.Parameters.Add("@idFuncionalidad9", SqlDbType.NVarChar).Value = funcionalidadesParaRol[8];
                    procedure.Parameters.Add("@idFuncionalidad10", SqlDbType.NVarChar).Value = funcionalidadesParaRol[9];
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

            return textoNombre.Text != "" && (funcionalidadesParaRol[0] != "" || funcionalidadesParaRol[1] != "" ||
                funcionalidadesParaRol[2] != "" || funcionalidadesParaRol[3] != "" ||
                funcionalidadesParaRol[4] != "" || funcionalidadesParaRol[5] != "" ||
                funcionalidadesParaRol[6] != "" || funcionalidadesParaRol[7] != "" ||
                funcionalidadesParaRol[8] != "" || funcionalidadesParaRol[9] != "");

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

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarFuncionalidad(string funcionalidad)
        {
            if (this.posicion < 9 || !funcionalidadesParaRol.Contains(funcionalidad))
            {
                this.funcionalidadesParaRol.Insert(this.posicion, funcionalidad);
                this.posicion++;
            }
            else
            {
                throw new Exception("Ya contiene esa funcionalidad, elija otra");
            }
        }
        private void SeleccionFuncionalidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridFuncionalidades.CurrentRow == null) return;
                if (this.dataGridFuncionalidades.CurrentRow.Cells[0] == null) return;
                string funcionalidad = this.dataGridFuncionalidades.CurrentRow.Cells["id_funcionalidad"].Value.ToString();

                int indice = this.dataGridSeleccionadas.Rows.Count - 1;

                this.agregarFuncionalidad(funcionalidad);

                this.dataGridSeleccionadas.Rows.Add(funcionalidad);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void DataGridSeleccionadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarFuncionalidad(String funcionalidad)
        {
            if (posicion > 0 && funcionalidadesParaRol.Contains(funcionalidad))
            {
                this.posicion--;
                this.funcionalidadesParaRol.Insert(posicion,"");
            }
            else
            {
                throw new Exception("No contiene la funcionalidad");
            }
        }
        private void Quitar_Click(object sender, EventArgs e)
        {
            int indice = this.dataGridSeleccionadas.Rows.Count - 1;
            if (indice == -1) return;
            try
            {
                String funcionalidad = this.dataGridSeleccionadas.Rows[indice - 1].Cells["FuncionalidadesAgregadas"].Value.ToString();
                this.eliminarFuncionalidad(funcionalidad);
                this.dataGridSeleccionadas.Rows[indice].Cells["FuncionalidadesAgregadas"].Value = "";
                this.dataGridSeleccionadas.Rows.RemoveAt(indice - 1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
