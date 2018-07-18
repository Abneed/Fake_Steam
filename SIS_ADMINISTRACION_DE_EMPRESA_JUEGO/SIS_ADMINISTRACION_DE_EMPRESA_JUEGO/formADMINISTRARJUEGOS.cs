using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    public partial class formADMINISTRARJUEGOS : Form
    {
        public formADMINISTRARJUEGOS()
        {
            InitializeComponent();
        }

        private void radEliminar_CheckedChanged(object sender, EventArgs e)
        {
            radAgregar.Checked = false;
            radModificar.Checked = false;
        }

        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            radEliminar.Checked = false;
            radModificar.Checked = false;
        }

        private void radModificar_CheckedChanged(object sender, EventArgs e)
        {
            radAgregar.Checked = false;
            radEliminar.Checked = false;
        }
    }
}
