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
    public partial class VentanaSeleccionarviaje : Form
    {
        public VentanaSeleccionarviaje()
        {
            InitializeComponent();
            SetDefaults();
        }

        public BaseDeDato bd = new BaseDeDato();
        public DataTable dt = new DataTable();

        private Cliente cliente;

        public void CargarCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        #region DataGridView


        /*
        public void dataGridViewCargar(DataGridView dataGridView, DataSet vista)
        {
            dataGridView.DataSource = vista;
        }*/
      /*  public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlCommand command = bd.ejecutarConsulta("SELECT * FROM [LEISTE_EL_CODIGO?].CrucerosDisponibles");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
        */
        /*
        public void dataGridViewAgregarBotonSeleccionar(DataGridView dataGridView)
        {
            DataGridViewButtonColumn botonSeleccion = new DataGridViewButtonColumn();
            botonSeleccion.HeaderText = "Seleccionar";
            botonSeleccion.Text = "Seleccionar";
            botonSeleccion.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(botonSeleccion);
        }*/

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SetDefaults()
        {
            this.dateTimePicker1.MinDate = DateTime.Now;
        }

        private void VentanaSeleccionarviaje_Load(object sender, EventArgs e)
        {
            this.llenarComboOrigen(listaOrigen);
            this.llenarComboDestino(listaDestino);
        }
        /*
        public void llenardataGridView(DataGridView dgv)
        {
            bd.conectar();
            SqlConnection conexion = bd.obtenerConexion();
            SqlCommand command = new SqlCommand("SELECT * FROM [LEISTE_EL_CODIGO?].Viaje", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
            bd.desconectar();
        }*/



        private void textoFechaInicio_TextChanged(object sender, EventArgs e)
        {
            //this.filtrarDataGrdView(viajesDisponibles, "SELECT * FROM [LEISTE_EL_CODIGO?].Viaje WHERE fecha_inicio LIKE ('" + this.dateTimePicker1.Value + "%')");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        public void filtrarDataGrdView(DataGridView dgv, string nombreConsulta)
        {
            bd.conectar();
            SqlCommand consulta = new SqlCommand(nombreConsulta, bd.obtenerConexion());
            DataTable tabla = bd.obtenerDataTable(consulta);
            SqlDataAdapter adapter = new SqlDataAdapter(consulta);
            adapter.Fill(tabla);
            dgv.DataSource = tabla;
            bd.desconectar();
        }
        private void viajesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e) { }
        /*
        private void viajesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (viajesDisponibles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                viajesDisponibles.CurrentRow.Selected = true;

                int idTramo = Convert.ToInt32(viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                decimal id_recorrido = Convert.ToDecimal( viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                string id_crucero = viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString();
                DateTime fecha_inicio = Convert.ToDateTime( viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                DateTime fecha_finalizacion_estimada = Convert.ToDateTime(viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                DateTime fecha_finalizacion = Convert.ToDateTime(viajesDisponibles.Rows[e.RowIndex].Cells["id_Viaje"].Value.ToString());
                Viaje viajeSeleccionado = new Viaje(idTramo,id_recorrido,id_crucero,fecha_inicio,fecha_finalizacion_estimada,fecha_finalizacion);

            }
            else
            {

                MessageBox.Show("No hay tramos para agregar", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }*/

        private void viajesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonReserva_Click(object sender, EventArgs e)
        {
           
        }
        public void llenarComboOrigen(ComboBox cb)
        {

            BaseDeDato db = new BaseDeDato();
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand("SELECT distinct id_origen FROM [LEISTE_EL_CODIGO?].Tramo", conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            cb.DataSource = listaDeTramos;
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();
        }
        public void llenarComboDestino(ComboBox cb)
        {

            BaseDeDato db = new BaseDeDato();
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand("SELECT distinct id_destino FROM [LEISTE_EL_CODIGO?].Tramo", conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            cb.DataSource = listaDeTramos;
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();
        }

        /*
         devolverIdPago recibe un medio_de_pago y un cliente
         comprarPasaje for tantas veces
         verVoucher 
             */


        private void listaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].mostrarViajesDisponibles");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2).Value = this.dateTimePicker1.Value;
                procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = this.listaOrigen.SelectedItem.ToString();
                procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = this.listaDestino.SelectedItem.ToString();
                dt = bd.obtenerDataTable(procedure);
                this.viajesDisponibles.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonCargarCli_Click(object sender, EventArgs e)
        {
            new VentanaCargarCliente(this, cliente).Show();
        }
    }
}
