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

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaDarDeAltaRol : Form
    {
        BaseDeDato bd = new BaseDeDato();
        SqlDataAdapter adapt;
        DataTable dt;
        public VentanaDarDeAltaRol()
        {
            InitializeComponent();
        }
        private void VentanaDarDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.desconectar();
        }

        private void BotonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAlta_Click_1(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        { 
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VentanaModificarRol ventana = new VentanaModificarRol(comboBoxRoles.Text.ToString());
            ventana.Show();
            this.Hide();
        }
    }
}
