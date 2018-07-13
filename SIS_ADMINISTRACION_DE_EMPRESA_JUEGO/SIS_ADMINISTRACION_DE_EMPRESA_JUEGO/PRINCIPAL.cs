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
            frmLOGIN frm1 = new frmLOGIN();
            frm1.Visible = true;
            this.Dispose();
        }
    }
}
