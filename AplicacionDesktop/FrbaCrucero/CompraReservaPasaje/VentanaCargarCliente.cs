using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Data.SqlClient;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class VentanaCargarCliente : Form
    {
        VentanaSeleccionarviaje ventanaOriginal;
        Cliente cliente;
        int currentClientID;

        public VentanaCargarCliente(VentanaSeleccionarviaje ventanaOriginal,Cliente cliente)
        {
            this.ventanaOriginal = ventanaOriginal;
            InitializeComponent();
            if (cliente != null) AutoCargarCliente(cliente);
            SetDefaults();
        }

        private void AutoCargarCliente(Cliente cliente)//para el inicio de la ventana
        {
            this.cliente = cliente;
            currentClientID = cliente.id;
            this.textBoxDNI.Text = currentClientID.ToString();
            this.textBoxNombre.Text = cliente.nombre;
            this.textBoxApellido.Text = cliente.apellido;
            this.textBoxTelefono.Text = cliente.telefono.ToString();
            this.textBoxMail.Text = cliente.mail;
            this.dateTimePickerNacimiento.Value = cliente.fechaNacimiento;
            this.textBoxDireccion.Text = cliente.direccion;
        }

        private void SetDefaults()
        {
            this.dateTimePickerNacimiento.MaxDate = DateTime.Now;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //ingresarCliente (@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),
            //@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255))

                BaseDeDato bd = new BaseDeDato();

            try
            {
                DataTable dt;
                SqlCommand check = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].buscarPorDni");
                check.CommandType = CommandType.StoredProcedure;
                check.Parameters.Add("@dni", SqlDbType.Decimal).Value = decimal.Parse(this.textBoxDNI.Text);
                dt = bd.obtenerDataTable(check);

                switch (dt.Rows.Count)
                {
                    case 0:
                        CargarNuevoCliente();
                        break;
                    default:
                        ActualizarCliente();
                        break;
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }
        
        private void ActualizarCliente()
        {
            //actualizarUsuario (@idCliente int,@nombre varchar(255),@apellido varchar(255),@dni decimal(18, 0),
            //@telefono int,@mail nvarchar(255),@fecha_nacimiento datetime2(3),@direccion nvarchar(255)) 
            BaseDeDato bd = new BaseDeDato();
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            int dni = int.Parse(this.textBoxDNI.Text);
            int telefono = int.Parse(this.textBoxTelefono.Text);
            string mail = this.textBoxMail.Text;
            DateTime nacimiento = this.dateTimePickerNacimiento.Value;
            string direccion = this.textBoxDireccion.Text;
            SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].actualizarUsuario");
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add("@idCliente", SqlDbType.Int).Value = currentClientID;
            procedure.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            procedure.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            procedure.Parameters.Add("@dni", SqlDbType.Decimal).Value = decimal.Parse(this.textBoxDNI.Text);
            procedure.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            procedure.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            procedure.Parameters.Add("@fecha_nacimiento", SqlDbType.DateTime2).Value = nacimiento;
            procedure.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            bd.ejecutarConsultaSinResultado(procedure);

            Cliente cliente = new Cliente(currentClientID,nombre, apellido, dni, direccion, telefono, mail, nacimiento);

            this.ventanaOriginal.CargarCliente(cliente);
            this.Close();
        }

        private void CargarNuevoCliente()
        {
            BaseDeDato bd = new BaseDeDato();
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            int dni = int.Parse(this.textBoxDNI.Text);
            int telefono = int.Parse(this.textBoxTelefono.Text);
            string mail = this.textBoxMail.Text;
            DateTime nacimiento = this.dateTimePickerNacimiento.Value;
            string direccion = this.textBoxDireccion.Text;
            SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].ingresarCliente");
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            procedure.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            procedure.Parameters.Add("@dni", SqlDbType.Decimal).Value = decimal.Parse(this.textBoxDNI.Text);
            procedure.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            procedure.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            procedure.Parameters.Add("@fecha_nacimiento", SqlDbType.DateTime2).Value = nacimiento;
            procedure.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            procedure.Parameters.Add("@idCLiente", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            bd.ejecutarConsultaDevuelveInt(procedure);
            int idCliente = (int)procedure.Parameters["@idCLiente"].Value;

            Cliente cliente = new Cliente(idCliente, nombre, apellido, dni, direccion, telefono, mail, nacimiento);

            this.ventanaOriginal.CargarCliente(cliente);
            this.Close();
        }

        private void VentanaCargarCliente_Load(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                this.textBoxNombre.Text=cliente.nombre;
                this.textBoxApellido.Text=cliente.apellido;
                this.textBoxDNI.Text= cliente.dni.ToString();
                this.textBoxTelefono.Text= cliente.telefono.ToString();
                this.textBoxMail.Text=cliente.mail;
                this.dateTimePickerNacimiento.Value=cliente.fechaNacimiento;
                this.textBoxDireccion.Text=cliente.direccion;
            }
        }

        private void AutoCargarDatosCliente(DataGridViewRow dr)
        {
            currentClientID = (int)dr.Cells["id_cliente"].Value;
            this.textBoxNombre.Text = dr.Cells["nombre"].Value.ToString();
            this.textBoxApellido.Text = dr.Cells["apellido"].Value.ToString();
            this.textBoxTelefono.Text = dr.Cells["telefono"].Value.ToString();
            this.textBoxMail.Text = dr.Cells["mail"].Value.ToString();
            this.dateTimePickerNacimiento.Value = (DateTime)dr.Cells["fecha_nacimiento"].Value;
            this.textBoxDireccion.Text = dr.Cells["direccion"].Value.ToString();
        }

        public void EnviarDataRowDni(DataGridViewRow dr)
        {
            AutoCargarDatosCliente(dr);
        }

        private void AutoCargarCliDT(DataTable dnis)
        {
            currentClientID = (int)dnis.Rows[0]["id_cliente"];
            this.textBoxNombre.Text = dnis.Rows[0]["nombre"].ToString();
            this.textBoxApellido.Text = dnis.Rows[0]["apellido"].ToString();
            this.textBoxTelefono.Text = dnis.Rows[0]["telefono"].ToString();
            this.textBoxMail.Text = dnis.Rows[0]["mail"].ToString();
            this.dateTimePickerNacimiento.Value = (DateTime)dnis.Rows[0]["fecha_nacimiento"];
            this.textBoxDireccion.Text = dnis.Rows[0]["direccion"].ToString();
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BaseDeDato bd = new BaseDeDato();
                DataTable dt;
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].buscarPorDni");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@dni", SqlDbType.Decimal).Value = decimal.Parse(this.textBoxDNI.Text);
                dt = bd.obtenerDataTable(procedure);

                switch (dt.Rows.Count)
                {
                    case 0:
                        break;
                    case 1:
                        AutoCargarCliDT(dt);
                        break;
                    default:
                        new DNIDuplicado(this, dt).Show();
                        break;
                }
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void DateTimePickerNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
