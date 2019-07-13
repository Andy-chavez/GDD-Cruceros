using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmRol;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.PagoReserva;
using System.Data.SqlClient;
using FrbaCrucero.Clases;




namespace FrbaCrucero
{
    public partial class VentanaMenu : Form
    {


        public string usuario;
        public VentanaMenu()

        {
            InitializeComponent();
            this.Visible = false;
            this.FormClosed += cerrarPrograma;
        }
        
        void cerrarPrograma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaMenu_Load(object sender, EventArgs e)
        {
          
            
        }

        public void botonAdmCrucero_Click(object sender, EventArgs e)
        {
            new VentanaGestionCrucero().Show();
            
        }

        public void botonPago_Click(object sender, EventArgs e)
        {
            new VentanaPagoDeReserva().Show();
        }

        public void botonReserva_Click(object sender, EventArgs e)
        {
            new VentanaSeleccionarviaje().Show();
        }

        public void botonAdmRecorrido_Click(object sender, EventArgs e)
        {
            new VentanaGestionRecorrido(this).Show();
        }

        public void botonAbmRol_Click(object sender, EventArgs e)
        {
            new VentanaGestionRol(this).Show();
        }

        public void botonViaje_Click(object sender, EventArgs e)
        {
            new GenerarViaje().Show();
        }

        public void botonEstadisticas_Click(object sender, EventArgs e)
        {
            new ListadoEstadistico.ListadoEstadistico().Show();
        }
        public void ocultarBotones(string usuario)
        {
            if (usuario == "cliente")
            {
                botonAdmRecorrido.Hide();
                botonAdmCrucero.Hide();
                botonAbmRol.Hide();
                botonEstadisticas.Hide();
                botonViaje.Hide();
                return;
            }
            BaseDeDato bd = new BaseDeDato();
            SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].itemsMenu");
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add("@id_ingresado", SqlDbType.NVarChar).Value = usuario;
            procedure.Parameters.Add("@puedeReco", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeCrucero", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeRol", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeEst", SqlDbType.Int).Direction = ParameterDirection.Output;
            procedure.Parameters.Add("@puedeViaje", SqlDbType.Int).Direction = ParameterDirection.Output;
            bd.ejecutarConsultaSinResultado(procedure);

            int reco = Convert.ToInt32(procedure.Parameters["@puedeReco"].Value);
            int crucero = Convert.ToInt32(procedure.Parameters["@puedeCrucero"].Value);
            int rol = Convert.ToInt32(procedure.Parameters["@puedeRol"].Value);
            int estadisticas = Convert.ToInt32(procedure.Parameters["@puedeEst"].Value);
            int viaje = Convert.ToInt32(procedure.Parameters["@puedeViaje"].Value);

            if(reco == 0) botonAdmRecorrido.Hide();
            if (crucero == 0) botonAdmCrucero.Hide();
            if (rol == 0) botonAbmRol.Hide();
            if (estadisticas == 0) botonEstadisticas.Hide();
            if (viaje == 0) botonViaje.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
           Application.Exit();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new VentanaPagoDeReserva().Show();
        }
    }
}
