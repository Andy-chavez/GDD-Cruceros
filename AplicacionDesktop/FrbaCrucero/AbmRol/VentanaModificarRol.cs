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
       
        private String id;
        private int posicion = 0;
        private List<String> funcionalidadesParaRol = new List<string>();
        // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        public VentanaModificarRol(string idRol)
        {
            InitializeComponent();
            this.dataGridTiene.ColumnCount = 1;
            this.dataGridTiene.Columns[0].Name = "Funcionalidad";
            this.dataGridNoTiene.ColumnCount = 1;
            this.dataGridNoTiene.Columns[0].Name = "Funcionalidad";
            this.id = idRol;
            rolSelect.Text = idRol;
            rolSelect.Enabled = false;            
            this.cargarListaFuncionalidades(idRol);
            //this.llenarFuncionalidades(idRol);
            this.llenarNoFuncionalidades(idRol);
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
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
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.dataGridTiene.Rows.Count - 1;
            if (indice == -1) return;
            try
            {
                String funcionalidad = this.dataGridTiene.Rows[indice].Cells["Funcionalidad"].Value.ToString();
                this.eliminarFuncionalidad(funcionalidad);
                this.dataGridTiene.Rows[indice].Cells["Funcionalidad"].Value = "";
                this.dataGridTiene.Rows.RemoveAt(indice);// - 1);
                /*this.dataGridNoTiene.DataSource = null;
                while (dataGridNoTiene.Rows.Count > 0)
                {
                    dataGridNoTiene.Rows.RemoveAt(0);
                }
                this.dtNT.Clear();
                this.llenarNoFuncionalidades(id);*/
                bool seEncontro = false;
                if (dataGridNoTiene.RowCount > 0)
                {
                    for (int i = 0; i < dataGridNoTiene.RowCount; i++)
                    {
                        if (dataGridNoTiene.Rows[i].Cells["Funcionalidad"].Value.ToString() == funcionalidad)
                        {
                            seEncontro = true;
                        }    
                    }
                }
                if(seEncontro == false)
                {
                    dataGridNoTiene.Rows.Add(funcionalidad);
                }
               // this.dataGridNoTiene.Rows.Add(funcionalidad);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        public bool todosLosCamposEstancompletos()
        {

            return textoNombre.Text != "" && (funcionalidadesParaRol.Any(item => item != ""));

        }
        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposEstancompletos())
            {
                textoNombre.Enabled = false;
                try
                {
                    int cantElementos = this.funcionalidadesParaRol.Count();
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearNuevoRolNombre");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                    bd.ejecutarConsultaSinResultado(procedure);
                    for (int i = 0; i < cantElementos; i++)
                    {
                        SqlCommand procedure2 = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].agregarFuncionalidadRol");
                        procedure2.CommandType = CommandType.StoredProcedure;
                        procedure2.Parameters.AddWithValue("@NombreRol", SqlDbType.NVarChar).Value = textoNombre.Text;
                        procedure2.Parameters.AddWithValue("@idFuncionalidad", SqlDbType.NVarChar).Value = funcionalidadesParaRol.ElementAt(i);
                        bd.ejecutarConsultaSinResultado(procedure2);
                    }
                    bd.desconectar();
                    MessageBox.Show("Rol modificado con exito");
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

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void llenarNoFuncionalidades(string idRol)
        {
            DataTable dtNT = new DataTable();
            SqlConnection con = new SqlConnection(bd.getConfig());
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            string sqlCmd = @"SELECT distinct id_funcionalidad Funcionalidad FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_funcionalidad not in (select id_funcionalidad
		FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_rol like @idRol)";
            cmd.CommandText = sqlCmd;

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRol", idRol);

            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //funcionalidadesParaRol.Insert(posicion, reader.GetString(0));
                this.dataGridNoTiene.Rows.Add(reader.GetString(0));
                //posicion++;
            }
            /*SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dtNT);
            dataGridNoTiene.DataSource = dtNT;*/
            con.Close();
        }
        private void llenarFuncionalidades(string idRol)
        {
            SqlConnection con = new SqlConnection(bd.getConfig());
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            string sqlCmd = @"SELECT id_funcionalidad Funcionalidad FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_rol = @idRol";
            cmd.CommandText = sqlCmd;

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRol", idRol);

            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            //comboBoxFuncionalidades.ValueMember = "id_funcionalidad";
            dataGridTiene.DataSource = dt;
        }

        private void RolSelect_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargarListaFuncionalidades(string idRol)
        {
            SqlConnection con = new SqlConnection(bd.getConfig());
            con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            string sqlCmd = @"SELECT id_funcionalidad Funcionalidad FROM [LEISTE_EL_CODIGO?].FuncionalidadPorRol WHERE id_rol = @idRol";
            cmd.CommandText = sqlCmd;

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idRol", idRol);

            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                funcionalidadesParaRol.Insert(posicion,reader.GetString(0));
                this.dataGridTiene.Rows.Add(funcionalidadesParaRol[posicion]);
                posicion++;
            }
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
           // DataTable dt = new DataTable();
           // sda.Fill(dt);
            con.Close();
            //comboBoxFuncionalidades.ValueMember = "id_funcionalidad";
            //dataGridTiene.DataSource = dt;

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridNoTiene.CurrentRow == null) return;
            if (this.dataGridNoTiene.CurrentRow.Cells[0] == null) return;
            if (funcionalidadesParaRol.Contains(this.dataGridNoTiene.CurrentRow.Cells["Funcionalidad"].Value.ToString())) return;

            this.funcionalidadesParaRol.Add(this.dataGridNoTiene.CurrentRow.Cells["Funcionalidad"].Value.ToString());
            this.dataGridTiene.Rows.Add(this.dataGridNoTiene.CurrentRow.Cells["Funcionalidad"].Value.ToString());
                    //funcionalidadesParaRol[i] = ;
                    //dt.Rows[posicion]["Funcionalidad"] = funcionalidadesParaRol[i];
                    //this.dataGridTiene.Rows.Add(funcionalidadesParaRol[i]);
                    //DataRow row = dt.NewRow();
                    //row[1]= funcionalidadesParaRol[i];
                    //dt.Rows.Add(funcionalidadesParaRol[i]);
                    //dt.Rows.Add(row);
                    return;
        }
        private void DataGridNoTiene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darAltaRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = rolSelect.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Operacion completada correctamente", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else if (retorno == 0) // ya esta habilitado
                { //no existe usuario
                    MessageBox.Show("El rol que selecciono ya estaba habilitado", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (retorno == -1) // no existe el rol
                { //no existe usuario
                    MessageBox.Show("No Existe el Rol", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darBajaRol");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idRol", SqlDbType.NVarChar).Value = rolSelect.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno == 1) //joya
                {
                    MessageBox.Show("Operacion completada correctamente", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else if (retorno == 0)
                { //no existe usuario
                    MessageBox.Show("El rol seleccionado ya se encontraba deshabilitado.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (retorno == -1) // no existe el rol
                { //no existe usuario
                    MessageBox.Show("No Existe el Rol", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
