using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Clases;

namespace FrbaCrucero.CompraReservaPasaje
{

    public partial class VentanaMedioDePago : Form
    {
        public DateTime fechaConfig = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"]);
        public int idPago;
        private int cliente;
        object ventanaOriginal;
        public VentanaMedioDePago(object ventanaOriginal,int cliente)
        {
            this.ventanaOriginal = ventanaOriginal;
            this.cliente = cliente;
            InitializeComponent();
        }
        BaseDeDato bd = new BaseDeDato();
        SqlDataAdapter adapt;
        DataTable dt;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaMedioDePago_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_medio_de_pago from [LEISTE_EL_CODIGO?].MedioDePago", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxMedios.DataSource = dt;
            comboBoxMedios.ValueMember = "id_medio_de_pago";
            bd.desconectar();

        }
        public void botonSeleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                BaseDeDato bd = new BaseDeDato();
                SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].devolverIdPago");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@idMedioPago", SqlDbType.NVarChar).Value = comboBoxMedios.Text;
                procedure.Parameters.AddWithValue("@idCliente", SqlDbType.Int).Value = this.cliente; //hay que determinar como llega
                procedure.Parameters.AddWithValue("@fechaConfig", SqlDbType.DateTime).Value = fechaConfig;
                procedure.Parameters.Add("@idPago", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                idPago = (int)procedure.Parameters["@idPago"].Value;
                if (idPago> 0) //joya
                {
                    MessageBox.Show("Se ha cargado su medio de pago, puede proceder con la compra de pasajes");

                    this.Hide();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
