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

        private void Cabinas_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int cabina = (int) this.CabinasParaSeleccionar.CurrentRow.Cells["id_cabina"].Value;
            try
            {
                ventanaOriginal.recibirIdCabina(cabina);
                cantidadPasajes--;
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una cabina distinta a las ya seleccionadas");
                return;
            }
            if (cantidadPasajes == 0)
            {
                MessageBox.Show("Cabinas Seleccionadas exitosamente proceda con el pago del pasaje");
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
    }
}
