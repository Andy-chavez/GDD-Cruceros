using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero;
using FrbaCrucero.Clases;
using System.Data.SqlClient;

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaListadoCrucero : Form
    {

        public VentanaListadoCrucero()
        {
            InitializeComponent();

        }

        public BaseDeDato bd = new BaseDeDato();
        public DataTable dt = new DataTable();

        #region DataGridView

        

        public void dataGridViewCargar(DataGridView dataGridView, DataSet vista)
        {
            dataGridView.DataSource = vista;
        }
        public void llenardataGridView(DataGridView dgv)
        
        {         
            bd.conectar();
            SqlCommand command = bd.ejecutarConsulta("SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles");
            SqlDataAdapter adapter = new SqlDataAdapter(command);         
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
       
        #endregion

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void botonBuscar_Click(object sender, EventArgs e) { 

            
            var lst = dt.Select(string.Format("id_crucero = '{0}'",filtro2.Text));

           //Declaras un nuevo dataTable para asignarlo a grid y no afectar el original
           var table = new DataTable();
           var column = new DataColumn();
           //Agregas las columnas correspondientes al nuevo dataTable
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "id_crucero";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "id_fabricante";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "modelo";
            table.Columns.Add(column);
         

            //LLenas el dataTable con el resultado de la busqueda
            foreach (DataRow row in lst)
            {
                table.ImportRow(row);
            }
           //Asignas el nuevo dataTable al grid
            planillaDeResultados.DataSource = table;
        }


        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            new VentanaListadoCrucero().Show();
        }

        private void filtro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void filtro1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void filtro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calendario_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            rsFiltro2.Text = Convert.ToDateTime(monthCalendar1.SelectionStart).ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void rsFiltro2_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            rsFiltro2.Text = Convert.ToDateTime(monthCalendar1.SelectionStart).ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void planillaDeResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaListado_Load(object sender, EventArgs e)
        {
            this.llenardataGridView(planillaDeResultados);
           /* this.crucerosDisponiblesTableAdapter.Fill(this.dataSet1.CrucerosDisponibles); */
          
        }

        private void grupoFiltro_Enter(object sender, EventArgs e, TextBox filtro)
        {

        }
        
    }
}
