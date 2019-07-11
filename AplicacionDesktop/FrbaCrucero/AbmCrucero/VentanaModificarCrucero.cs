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

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaModificarCrucero : Form
    {
        private BaseDeDato db = new BaseDeDato();
        public string fechaConfig = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];

        public VentanaModificarCrucero()
        {
            InitializeComponent();
            SetDefaults();

        }

        BaseDeDato bd = new BaseDeDato();
        DataTable dt = new DataTable();
        Crucero crucero = new Crucero();

        private void SetDefaults()
        {
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand("SELECT id_fabricante FROM [LEISTE_EL_CODIGO?].Fabricante", conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            comboBoxFabricante.DataSource = listaDeTramos;
            comboBoxFabricante.SelectedIndex = 0;
            comboBoxFabricante.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
        }


        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT distinct * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }

        private void VentanaModificarCrucero_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(dataGridView1);
            DateTime fechaActual = DateTime.Today;
            textoFecha.Text = fechaActual.ToString("dd/MM/yyyy");
        }

        private void textoModelo_TextChanged(object sender, EventArgs e)
        {
            this.filtrarDataGrdView(dataGridView1, "SELECT distinct * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles WHERE modelo LIKE ('" + textoModelo.Text + "%')");


        }
        public void filtrarDataGrdView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlCommand consulta = new SqlCommand(nombreConsulta, bd.obtenerConexion());
            DataTable tabla = bd.obtenerDataTable(consulta);
            //SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            //adapter.Fill(tabla);
            dgv.DataSource = tabla;
            bd.desconectar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null) return;
            if (this.dataGridView1.CurrentRow.Cells["id_crucero"] == null) return;
            if (e.RowIndex < 0) return;
            dataGridView1.CurrentRow.Selected = true;
            TextoCruceroSeleccionado.Text = dataGridView1.Rows[e.RowIndex].Cells["id_crucero"].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextoCruceroSeleccionado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoFabricanteNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextoCruceroSeleccionado.Text != "" && comboBoxFabricante.Text != "")
                {
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].modificarCrucero");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = TextoCruceroSeleccionado.Text;
                    procedure.Parameters.AddWithValue("@id_fabricante", SqlDbType.NVarChar).Value = comboBoxFabricante.Text;
                    db.ejecutarConsultaSinResultado(procedure);
                    MessageBox.Show("Operacion completada con exito.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void botonBajaTemp_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextoCruceroSeleccionado.Text != "" && textoFechaReinicio.Text!= "")
                {
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darDeBajaTemporalCrucero");
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = TextoCruceroSeleccionado.Text;
                    procedure.Parameters.AddWithValue("@fecha_reinicio", SqlDbType.DateTime).Value = Convert.ToDateTime(textoFechaReinicio.Text);
                    db.ejecutarConsultaSinResultado(procedure);
                    GestionDePasajesPorBaja gp = new GestionDePasajesPorBaja(TextoCruceroSeleccionado.Text.ToString());
                    gp.Show();
                    gp.esconderCosasTemporal();
                    this.Hide();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void botonBajaFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextoCruceroSeleccionado.Text != "")
                {
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].darDeBajaDefinitivaCrucero"); //(@id_crucero nvarchar(50),@fecha_actual datetime2)
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@id_crucero", SqlDbType.NVarChar).Value = TextoCruceroSeleccionado.Text;
                    DateTime enteredDate = DateTime.Parse(fechaConfig);
                    procedure.Parameters.AddWithValue("@fecha_actual", SqlDbType.DateTime).Value = enteredDate;
                    db.ejecutarConsultaSinResultado(procedure);

                    GestionDePasajesPorBaja gp = new GestionDePasajesPorBaja(TextoCruceroSeleccionado.Text.ToString());
                    gp.Show();
                    gp.esconderCosasDefinitiva();
                    this.Hide();

                    // MessageBox.Show("Operacion completada con exito.", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la base de datos", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textoFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        public void esconderCosasDeBaja()
        {
            labelFecha.Hide();
            textoFecha.Hide();
            botonBajaFinal.Hide();
            botonBajaTemp.Hide();
            buttonFechaReinicio.Hide();
            label4.Hide();
            textoFechaReinicio.Hide();
        }
        public void esconderCosasDeModificar()
        {
            label3.Hide();
            botonModificar.Hide();
            comboBoxFabricante.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {

            TextoCruceroSeleccionado.Clear();
            textoModelo.Clear();
            textoFechaReinicio.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textoFechaReinicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonFechaReinicio_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textoFechaReinicio.Text = Convert.ToDateTime(monthCalendar1.SelectionStart).ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
