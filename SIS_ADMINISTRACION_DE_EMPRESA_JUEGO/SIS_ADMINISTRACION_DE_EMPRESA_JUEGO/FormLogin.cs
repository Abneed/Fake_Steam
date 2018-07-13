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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        ~ FormLogin()
        {
            this.Dispose();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrin = new frmPrincipal();
            frmPrin.Show();
            this.Visible = false;
        }
    }
}
