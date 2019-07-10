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
        //private List<String> funcionalidadesParaRol = new List<string>() { "", "", "", "", "", "", "", "", "", "" };
        private List<String> funcionalidadesParaRol = new List<string>();
        // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        private void VentanaDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad Funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridFuncionalidades.DataSource = dt;
            bd.desconectar();
            //vaciarFuncionalidades();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void vaciarFuncionalidades()
        {
            dataGridSeleccionadas.DataSource = null;
            while (dataGridSeleccionadas.Rows.Count > 0)

            {

                dataGridSeleccionadas.Rows.RemoveAt(0);

            }
            int cantElementos = this.funcionalidadesParaRol.Count();
            for (int i = 0; i < cantElementos; i++)
            {
                funcionalidadesParaRol[i] = "";

            }
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposEstancompletos())
            {
                textoNombre.Enabled = false;
                BaseDeDato bd = new BaseDeDato();
                try
                {
                    int cantElementos = this.funcionalidadesParaRol.Count();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearNuevoRolNombre");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                    bd.ejecutarConsultaSinResultado(procedure);
                    for (int i=0; i < cantElementos; i++)
                    {
                        SqlCommand procedure2 = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].agregarFuncionalidadRol");
                        procedure.CommandType = CommandType.StoredProcedure;
                        procedure.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                        procedure.Parameters.AddWithValue("@idFuncionalidad", SqlDbType.NVarChar).Value = funcionalidadesParaRol[i];
                        bd.ejecutarConsultaSinResultado(procedure);
                    }
                    bd.desconectar();
                    /*BaseDeDato bd2 = new BaseDeDato();
                    SqlCommand procedure2 = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearNuevoRol");
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
                    procedure.Parameters.Add("@valor_retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    bd2.ejecutarConsultaDevuelveInt(procedure);
                    int retorno = (int)procedure.Parameters["@valor_retorno"].Value;
                    if (retorno == 1) //joya
                    {
                        bd2.desconectar();
                        MessageBox.Show("Rol creado exitosamente.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textoNombre.Clear();
                        textoNombre.Enabled = true;
                        vaciarFuncionalidades();
                    }
                    else if (retorno == -2) // no existe funcionalidad
                    {
                        bd2.desconectar();
                        MessageBox.Show("No Existe dicha Funcionalidad.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    else if (retorno == -5) // el rol ya tiene esa funcionalidad
                    {
                        bd2.desconectar();
                        MessageBox.Show("Error al cargar el rol.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (retorno == -4) // el rol ya tiene esa funcionalidad
                    {
                        bd2.desconectar();
                        MessageBox.Show("El nombre de rol ingresado ya existe.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (retorno == -3) // el rol ya tiene esa funcionalidad
                    {
                        bd2.desconectar();
                        MessageBox.Show("El nombre de rol ingresado ya posee la funcionalidad seleccionada.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete el nombre del rol y seleccione al menos una funcionalidad", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return textoNombre.Text != "" && (funcionalidadesParaRol.Any(item => item != ""));

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
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridFuncionalidades.CurrentRow == null) return;
            if (this.dataGridFuncionalidades.CurrentRow.Cells[0] == null) return;
            if (funcionalidadesParaRol.Contains(this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString())) return;
            this.funcionalidadesParaRol.Add(this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString());
            this.dataGridSeleccionadas.Rows.Add(this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString());
            /*for (int i = 0; i < 10; i++)
            {
                if (funcionalidadesParaRol[i] == "")
                {
                    this.funcionalidadesParaRol.Insert(i, this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString());
                    //funcionalidadesParaRol[i] = ;
                    posicion++;
                    this.dataGridSeleccionadas.Rows.Add(funcionalidadesParaRol[i]);
                    return;
                }
            }*/
        }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SeleccionFuncionalidad_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (this.dataGridFuncionalidades.CurrentRow == null) return;
                if (this.dataGridFuncionalidades.CurrentRow.Cells[0] == null) return;
                string funcionalidad = this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString();

                int indice = this.dataGridSeleccionadas.Rows.Count - 1;

                this.agregarFuncionalidad(funcionalidad);

                this.dataGridSeleccionadas.Rows.Add(funcionalidad);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }*/
        }

        private void DataGridSeleccionadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarFuncionalidad(String funcionalidad)
        {
            if (posicion > 0 && funcionalidadesParaRol.Contains(funcionalidad))
            {
                this.funcionalidadesParaRol.Remove(funcionalidad);//
                //this.funcionalidadesParaRol.Insert(posicion,"");
                //this.posicion--;
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
                String funcionalidad = this.dataGridSeleccionadas.Rows[indice].Cells["FuncionalidadesAgregadas"].Value.ToString();
                this.eliminarFuncionalidad(funcionalidad);
                this.dataGridSeleccionadas.Rows[indice].Cells["FuncionalidadesAgregadas"].Value = "";
                this.dataGridSeleccionadas.Rows.RemoveAt(indice);// - 1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
