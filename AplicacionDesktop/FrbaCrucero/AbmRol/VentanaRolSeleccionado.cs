using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaRolSeleccionado : Form
    {
        public VentanaRolSeleccionado()
        {
            InitializeComponent();
        }

        private void VentanaRolSeleccionado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFuncMod.FuncionalidadPorRol' Puede moverla o quitarla según sea necesario.
            this.funcionalidadPorRolTableAdapter.Fill(this.dataSetFuncMod.FuncionalidadPorRol);

        }
    }
}
