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
    public partial class frmPrincipal : Form
    {
        public string USUARIO = "";
        public string CONTRA = "";
        public frmPrincipal()
        {
            InitializeComponent();
        }
        ~frmPrincipal()
        {
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin frm1 = new FormLogin();
            frm1.Visible = true;
            this.Dispose();
        }

        private void btnAGREGARUSUARIO_Click(object sender, EventArgs e)
        {
            FormAGREGARUSUARIO FRMUSUARIO = new FormAGREGARUSUARIO();
            FRMUSUARIO.CONTRA = this.CONTRA;
            FRMUSUARIO.USAURIO = this.USUARIO;
            FRMUSUARIO.Show();
            //this.Visible = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblMostarUsuario.Text = USUARIO;
            lblMOSTARCONTRA.Text = CONTRA;
        }
    }
}
