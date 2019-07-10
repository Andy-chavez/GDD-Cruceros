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
        private List<String> funcionalidadesParaRol = new List<string>() { "", "", "", "", "", "", "", "", "", "" };
        // private Rol rol = new Rol();
        SqlDataAdapter adapt;
        public VentanaModificarRol(string idRol)
        {
            InitializeComponent();
            this.dataGridTiene.ColumnCount = 1;
            this.dataGridTiene.Columns[0].Name = "Funcionalidad";
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
            if (posicion > 0 && funcionalidadesParaRol.Contains(funcionalidad))
            {
                this.funcionalidadesParaRol.Remove(funcionalidad);//
                this.funcionalidadesParaRol.Insert(posicion, "");
                this.posicion--;
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
                this.dataGridNoTiene.DataSource = null;
                while (dataGridNoTiene.Rows.Count > 0)
                {
                    dataGridNoTiene.Rows.RemoveAt(0);
                }
                //this.dtNT.Clear();
                this.llenarNoFuncionalidades(id);

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

            return textoNombre.Text != "" && (funcionalidadesParaRol[0] != "" || funcionalidadesParaRol[1] != "" ||
                funcionalidadesParaRol[2] != "" || funcionalidadesParaRol[3] != "" ||
                funcionalidadesParaRol[4] != "" || funcionalidadesParaRol[5] != "" ||
                funcionalidadesParaRol[6] != "" || funcionalidadesParaRol[7] != "" ||
                funcionalidadesParaRol[8] != "" || funcionalidadesParaRol[9] != "");

        }
        private void BotonAgregar_Click(object sender, EventArgs e)
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
                    bd.desconectar();
                    if (retorno == 1) //joya
                    {
                        bd.desconectar();
                        MessageBox.Show("Rol creado exitosamente.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            bd.conectar();
                            SqlCommand prc = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearNuevoRol");
                            prc.CommandType = CommandType.StoredProcedure;
                            prc.Parameters.AddWithValue("@idRolViejo", SqlDbType.NVarChar).Value = this.id;
                            prc.Parameters.Add("@idRolNuevo", SqlDbType.NVarChar).Value = textoNombre.Text;
                            bd.ejecutarConsultaSinResultado(prc);
                            bd.desconectar();
                        }
                        catch (Exception exception)
                        {
                            bd.desconectar();
                            MessageBox.Show("Error en la base de datos.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dtNT);
            con.Close();
            dataGridNoTiene.DataSource = dtNT;
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
            for (int i = 0; i < 10; i++)
            {
                if (funcionalidadesParaRol[i] == "")
                {
                    this.funcionalidadesParaRol.Insert(i, this.dataGridNoTiene.CurrentRow.Cells["Funcionalidad"].Value.ToString());
                    this.dataGridTiene.Rows.Add(funcionalidadesParaRol[i]);
                    //funcionalidadesParaRol[i] = ;
                    //dt.Rows[posicion]["Funcionalidad"] = funcionalidadesParaRol[i];
                    posicion++;
                    //this.dataGridTiene.Rows.Add(funcionalidadesParaRol[i]);
                    //DataRow row = dt.NewRow();
                    //row[1]= funcionalidadesParaRol[i];
                    //dt.Rows.Add(funcionalidadesParaRol[i]);
                    //dt.Rows.Add(row);
                    return;
                }
            }
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
