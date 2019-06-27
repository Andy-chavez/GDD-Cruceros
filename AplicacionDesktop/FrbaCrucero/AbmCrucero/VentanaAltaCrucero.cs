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
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaAltaCrucero : Form
    {
        public BaseDeDato db = new BaseDeDato();

        public VentanaAltaCrucero()
        {
            InitializeComponent();
            DefaultConfig();
        }

        private void VentanaAltaCrucero_Load(object sender, EventArgs e)
        {

        }

        void DefaultConfig()
        {
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand("SELECT id_fabricante FROM [LEISTE_EL_CODIGO?].Fabricante", conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            comboBoxFabID.DataSource = listaDeTramos;
            comboBoxFabID.SelectedIndex = 0;
            comboBoxFabID.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();

            db.conectar();
            SqlConnection conexion2 = db.obtenerConexion();
            SqlCommand consulta2 = new SqlCommand("SELECT distinct(modelo) FROM [LEISTE_EL_CODIGO?].Crucero", conexion2);
            List<String> listaDeTramos2 = db.obtenerListaDeDatos(consulta2);
            comboModelo.DataSource = listaDeTramos2;
            comboModelo.SelectedIndex = 0;
            comboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();

        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposCompletos())
                {
                    if (EsIDCruceroNuevo()) //balcon, est, ext, ejec, suite
                    {
                        SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].cargarCrucero");
                        procedure.CommandType = CommandType.StoredProcedure;
                        procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = textoIdCrucero.Text;
                        procedure.Parameters.Add("@id_fabricante", SqlDbType.NVarChar).Value = comboBoxFabID.SelectedItem.ToString();
                        procedure.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = comboModelo.Text;
                        procedure.Parameters.Add("@cantidadBalcon", SqlDbType.Int).Value = Convert.ToInt32(balcon.Text);
                        procedure.Parameters.Add("@cantidadEstandar", SqlDbType.Int).Value = Convert.ToInt32(estandar.Text);
                        procedure.Parameters.Add("@cantidadExterior", SqlDbType.Int).Value = Convert.ToInt32(exterior.Text);
                        procedure.Parameters.Add("@cantidadEjecutivo", SqlDbType.Int).Value = Convert.ToInt32(ejecutiva.Text);
                        procedure.Parameters.Add("@cantidadSuite", SqlDbType.Int).Value = Convert.ToInt32(suite.Text);
                        procedure.Parameters.Add("@valor_retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                        db.ejecutarConsultaDevuelveInt(procedure);
                        int retorno = (int)procedure.Parameters["@valor_retorno"].Value;

                        switch (retorno)
                        {
                            case -1:
                                MessageBox.Show("No existe el fabricante");
                                break;
                            case -2:
                                MessageBox.Show("Cantidad de cabinas invalida");
                                break;
                            case 1:
                                MessageBox.Show("Nuevo crucero creado");
                                break;
                            default:
                                MessageBox.Show("Error desconocido");
                                break;
                        }

                    }
                    else MessageBox.Show("El ID de crucero elegido ya existe", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool EsIDCruceroNuevo()
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                bd.conectar();
                SqlCommand sqlCommand = Clases.BaseDeDato.crearConsulta("SELECT COUNT(*) from [LEISTE_EL_CODIGO?].Crucero where id_crucero like @idCruc");
                sqlCommand.Parameters.Add("@idCruc", SqlDbType.NVarChar).Value = textoIdCrucero.Text;
                int Count = (int)sqlCommand.ExecuteScalar();
                bd.desconectar();
                if (Count == 0) return true;
                else return false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void textoIdCrucero_TextChanged(object sender, EventArgs e)
        {

        }

        private void texoIdFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoCabina_TextChanged(object sender, EventArgs e)
        {

        }

        public bool CamposCompletos()
        {

            return textoIdCrucero.Text != "" && ejecutiva.Text != "" && suite.Text != ""
                && exterior.Text != "" && estandar.Text != ""
                && balcon.Text != "";

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            ejecutiva.Clear();
            textoIdCrucero.Clear();
            //textoModelo.Clear();
        }

        private void botonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
