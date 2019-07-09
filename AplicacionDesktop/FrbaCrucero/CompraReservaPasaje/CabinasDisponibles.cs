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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class CabinasDisponibles : Form
    {
        public BaseDeDato bd = new BaseDeDato();
        public DataTable dt = new DataTable();
        public int idViaje;
        public int cantidadPasajes;
        VentanaSeleccionarviaje ventanaOriginal;
        public CabinasDisponibles(int idViaje, VentanaSeleccionarviaje ventanaOriginal,int cantidadPasajes)
        {
            this.idViaje = idViaje;
            this.ventanaOriginal = ventanaOriginal;
            InitializeComponent();
            this.cantidadPasajes = cantidadPasajes;
        }

        public void setDefaults()
        {
            this.dataGridSeleccionadas.ColumnCount = 3;
            this.dataGridSeleccionadas.Columns[0].Name = "Cabina";
            this.dataGridSeleccionadas.Columns[1].Name = "Piso";
            this.dataGridSeleccionadas.Columns[2].Name = "Numero";
            this.dataGridSeleccionadas.Columns[3].Name = "Tipo";
            this.dataGridSeleccionadas.Columns[4].Name = "Servicio";
            this.dataGridSeleccionadas.EditingControlShowing += dataGridSeleccionadas_EditingControlShowing;
            this.dataGridSeleccionadas.Columns[0].ReadOnly = true;
            this.dataGridSeleccionadas.Columns[1].ReadOnly = true;
            this.dataGridSeleccionadas.Columns[2].ReadOnly = true;
            this.dataGridSeleccionadas.Columns[3].ReadOnly = true;
            this.dataGridSeleccionadas.Columns[4].ReadOnly = true;
        }

        private void dataGridSeleccionadas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            if (dataGridSeleccionadas.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
        }

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridSeleccionadas.CurrentRow.Cells["Cabina"].Value.ToString() == ""
                || this.dataGridSeleccionadas.CurrentRow.Cells["Piso"].Value.ToString() == ""
                || this.dataGridSeleccionadas.CurrentRow.Cells["Numero"].Value.ToString() == ""
                || this.dataGridSeleccionadas.CurrentRow.Cells["Tipo"].Value.ToString() == ""
                || this.dataGridSeleccionadas.CurrentRow.Cells["Servicio"].Value.ToString() == "")
            {
                e.Handled = true;
                return;
            }
        }
        private void Cabinas_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int cabina = (int) this.CabinasParaSeleccionar.CurrentRow.Cells["id_cabina"].Value;
            try
            {
                if (this.CabinasParaSeleccionar.CurrentRow == null) return;
                if (this.CabinasParaSeleccionar.CurrentRow.Cells[0] == null) return;
                int idCabina = Convert.ToInt32(this.CabinasParaSeleccionar.CurrentRow.Cells["id_cabina"].Value);
                int piso = Convert.ToInt32(this.CabinasParaSeleccionar.CurrentRow.Cells["id_cabina"].Value);
                int numero = Convert.ToInt32(this.CabinasParaSeleccionar.CurrentRow.Cells["id_cabina"].Value);
                string idTipo = this.CabinasParaSeleccionar.CurrentRow.Cells["id_tipo"].Value.ToString();
                string descripcion = this.CabinasParaSeleccionar.CurrentRow.Cells["servicioAsociado"].Value.ToString();

                int indice = this.dataGridSeleccionadas.Rows.Count - 1;
                if (indice == -1)
                {
                    this.dataGridSeleccionadas.Rows.Add(idCabina,piso,numero,idTipo,descripcion);
                }
                else
                {
                    this.dataGridSeleccionadas.Rows[indice].Cells["Cabina"].Value = idCabina;
                    this.dataGridSeleccionadas.Rows[indice].Cells["Piso"].Value = piso;
                    this.dataGridSeleccionadas.Rows[indice].Cells["Numero"].Value = numero;
                    this.dataGridSeleccionadas.Rows[indice].Cells["Tipo"].Value = idTipo;
                    this.dataGridSeleccionadas.Rows[indice].Cells["Servicio"].Value = descripcion;
                }
                ventanaOriginal.recibirIdCabina(cabina);
                cantidadPasajes--;

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                //MessageBox.Show("Debe seleccionar una cabina distinta a las ya seleccionadas");
                return;
            }
            if (cantidadPasajes == 0)
            {
                MessageBox.Show("Cabinas Seleccionadas exitosamente proceda con el pago del pasaje o a cargar sus datos");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cabina seleccionada le faltan seleccionar "+ cantidadPasajes + " cabina/s");
                return;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CabinasDisponibles_Load(object sender, EventArgs e)
        {
            this.llenarGridCabinas();
        }
        public void llenarGridCabinas() {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                bd.conectar();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].mostrarCabinasLibres");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idViaje", SqlDbType.Int).Value = this.idViaje;
                dt = bd.obtenerDataTable(procedure);
                this.CabinasParaSeleccionar.DataSource = dt;
                bd.desconectar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
