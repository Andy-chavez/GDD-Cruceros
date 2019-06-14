using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class DNIDuplicado : Form
    {
        VentanaCargarCliente ventanaOrig;
        DataTable dnis;

        public DNIDuplicado(VentanaCargarCliente ventanaOrig, DataTable dnis)
        {
            this.ventanaOrig = ventanaOrig;
            InitializeComponent();
            this.dnis = dnis;
        }

        private void DNIDuplicado_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = dnis;
            this.dataGridView1.Rows[0].Selected = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            ventanaOrig.EnviarDataRowDni(dataGridView1.CurrentRow);
            this.Close();
        }
    }
}
