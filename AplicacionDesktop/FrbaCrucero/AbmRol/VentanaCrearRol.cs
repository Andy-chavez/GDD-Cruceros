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
        private List<String> funcionalidadesParaRol = new List<string>();
        SqlDataAdapter adapt;
        private void VentanaDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_funcionalidad Funcionalidad from [LEISTE_EL_CODIGO?].Funcionalidad", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridFuncionalidades.DataSource = dt;
            bd.desconectar();
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
            funcionalidadesParaRol.Clear();
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
                        procedure2.CommandType = CommandType.StoredProcedure;
                        procedure2.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                        procedure2.Parameters.AddWithValue("@idFuncionalidad", SqlDbType.NVarChar).Value = funcionalidadesParaRol.ElementAt(i);
                        bd.ejecutarConsultaSinResultado(procedure2);
                    }
                    bd.desconectar();
                    MessageBox.Show("Rol Creado con exito");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    textoNombre.Enabled = true;
                    bd.desconectar();
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
            if (e.RowIndex < 0) return;
            if (funcionalidadesParaRol.Contains(this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString())) return;
            this.funcionalidadesParaRol.Add(this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString());
            this.dataGridSeleccionadas.Rows.Add(this.dataGridFuncionalidades.CurrentRow.Cells["Funcionalidad"].Value.ToString());
        }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SeleccionFuncionalidad_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridSeleccionadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarFuncionalidad(String funcionalidad)
        {
            if (funcionalidadesParaRol.Contains(funcionalidad))
            {
                this.funcionalidadesParaRol.Remove(funcionalidad);
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
                this.dataGridSeleccionadas.Rows.RemoveAt(indice);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
