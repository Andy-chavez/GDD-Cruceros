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
using System.Collections;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class VentanaSeleccionarviaje : Form
    {
        public DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);
        public VentanaSeleccionarviaje()
        {
            InitializeComponent();
            SetDefaults();
        }

        public BaseDeDato bd = new BaseDeDato();
        public DataTable dt = new DataTable();

        private Cliente cliente;
        private ArrayList cabinas = new ArrayList();

        public void CargarCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void recibirIdCabina(int idCabina) {
            if (cabinas.Contains(idCabina))
            {
                throw new System.InvalidOperationException("Error ya contiene esta cabina");
            }
            this.cabinas.Add(idCabina);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SetDefaults()
        {
            this.dateTimePicker1.MinDate = fechaConfig;
            this.dateTimePicker1.Value = fechaConfig;
            this.comboBoxCantPasajes.SelectedIndex = 0;
        }

        private void VentanaSeleccionarviaje_Load(object sender, EventArgs e)
        {
            this.llenarComboOrigen(listaOrigen);
            this.llenarComboDestino(listaDestino);
        }
        public int viajeSeleccionado()
        {
            return (int)this.viajesDisponibles.CurrentRow.Cells["id_viaje"].Value;
        }

        private void textoFechaInicio_TextChanged(object sender, EventArgs e)
        {
            //this.filtrarDataGrdView(viajesDisponibles, "SELECT * FROM [LEISTE_EL_CODIGO?].Viaje WHERE fecha_inicio LIKE ('" + this.dateTimePicker1.Value + "%')");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void viajesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e) {
            textBoxCruceros.Text = viajesDisponibles.CurrentRow.Cells["crucero"].Value.ToString();
            textBoxCruceros.Enabled = false;
        }

        private void viajesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void botonReserva_Click(object sender, EventArgs e)
        {
            int cantidad_pasajes = Convert.ToInt32(this.comboBoxCantPasajes.SelectedItem);
            if (cantidad_pasajes != 1)
            {
                MessageBox.Show("Error: la cantidad de pasajes tiene que ser igual a 1 en las reservas");
                return;
            }
            if (this.cabinas.Count < cantidad_pasajes)
            {
                MessageBox.Show("Seleccione la cabina antes de realizar una reserva");
                return;
            }
            try
            {
                //BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearReserva");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@idCrucero", SqlDbType.NVarChar).Value = this.viajesDisponibles.CurrentRow.Cells["crucero"].Value;
                procedure.Parameters.Add("@idCliente", SqlDbType.Int).Value = this.cliente.id;
                procedure.Parameters.Add("@idViaje", SqlDbType.Int).Value = (int)this.viajesDisponibles.CurrentRow.Cells["id_viaje"].Value;
                //cuidado que hay que remodelar esto porque va a fallar de momento
                procedure.Parameters.Add("@idCabina", SqlDbType.Int).Value = (int) this.cabinas[0];
                procedure.Parameters.Add("@fechaConfig", SqlDbType.DateTime).Value = this.fechaConfig;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure); 
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                if (retorno != -1) //joya
                {
                    MessageBox.Show("Su numero de reserva es:"+retorno+"\nSi desea abonarlo, ingrese el codigo en la opcion Pagar del menú principal.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (retorno == -1) 
                {
                    MessageBox.Show("El cliente ya posee una reserva en dicha fecha. \nVerifique los campos.", "FrbaCrucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

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
                bd.conectar();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].mostrarViajesDisponibles");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@fecha_inicio", SqlDbType.DateTime2).Value = this.dateTimePicker1.Value;
                procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = this.listaOrigen.SelectedItem.ToString();
                procedure.Parameters.Add("@destino", SqlDbType.NVarChar).Value = this.listaDestino.SelectedItem.ToString();
                procedure.Parameters.Add("@fechaConfig", SqlDbType.DateTime).Value = this.fechaConfig;
                dt = bd.obtenerDataTable(procedure);
                this.viajesDisponibles.DataSource = dt;
                bd.desconectar();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int viaje = (int)this.viajesDisponibles.CurrentRow.Cells["id_viaje"].Value;
                //int id_cabina = (int)this.viajesDisponibles.CurrentRow.Cells["id_cabina"].Value;
                string id_crucero = this.viajesDisponibles.CurrentRow.Cells["crucero"].Value.ToString();
                int cantidad_pasajes = Convert.ToInt32(this.comboBoxCantPasajes.SelectedItem);
                new Compra(cliente, viaje, this.cabinas, id_crucero, cantidad_pasajes).Show();//necesita origen,destino,viaje,inicio,cantidad
                                                                                                 //compra va a crear la ventana medio de pago new ventanamediodepago(this,cliente.id).Show()
            }
            catch
            {
                MessageBox.Show("Error: Por favor seleccione la/s cabina/s deseada/s o cargue sus datos antes de proceder al pago de pasaje");
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id_crucero = this.viajesDisponibles.CurrentRow.Cells["crucero"].Value.ToString();
                int viaje = (int)this.viajesDisponibles.CurrentRow.Cells["id_viaje"].Value;
                int cantidadPasajes = Convert.ToInt32(this.comboBoxCantPasajes.SelectedItem);
                new CabinasDisponibles(viaje, this,cantidadPasajes).Show();
            }
            catch
            {
                MessageBox.Show("Por favor seleccione primero el viaje deseado para poder elejir las cabinas");
            }
        }

        private void TextBoxCruceros_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
