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
        public VentanaModificarCrucero()
     
        {
            InitializeComponent();

            
        }
        
        BaseDeDato bd = new BaseDeDato();
        DataTable dt = new DataTable();
        Crucero crucero = new Crucero();

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
        }

        
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles", conexion);
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
             this.filtrarDataGrdView(  dataGridView1 ,  "SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles WHERE modelo LIKE ('"+ textoModelo.Text + "%')");
            
            
        }
        public void filtrarDataGrdView( DataGridView dgv, string nombreConsulta){
            bd.conectar();
            SqlCommand consulta = new SqlCommand(nombreConsulta, bd.obtenerConexion());
            DataTable tabla = bd.obtenerDataTable(consulta);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            adapter.Fill(tabla);
            dgv.DataSource = tabla;
            bd.desconectar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                TextoCruceroSeleccionado.Text = dataGridView1.Rows[e.RowIndex].Cells["id_crucero"].Value.ToString();
            }


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
            crucero.modificarCrucero((TextoCruceroSeleccionado.Text), (textoFabricanteNuevo.Text));
        }

        private void botonBajaTemp_Click(object sender, EventArgs e)
        {

        }

        private void botonBajaFinal_Click(object sender, EventArgs e)
        {
            crucero.bajaDefinitiva(Convert.ToDateTime(textoFecha.Text), TextoCruceroSeleccionado.Text.ToString());
        }

        private void textoFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        public void esconderCosasDeBaja(){
            labelFecha.Hide();
            textoFecha.Hide();
            botonBajaFinal.Hide();
            botonBajaTemp.Hide(); 
        }
        public void esconderCosasDeModificar()
        {
            label3.Hide();
            botonModificar.Hide();
            textoFabricanteNuevo.Hide();
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            textoFecha.Clear();
            textoFabricanteNuevo.Clear();
            TextoCruceroSeleccionado.Clear();
            textoModelo.Clear();
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
