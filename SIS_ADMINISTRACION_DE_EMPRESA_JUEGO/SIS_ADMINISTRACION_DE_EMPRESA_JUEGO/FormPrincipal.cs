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

namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    public partial class frmPrincipal : Form
    {
        public string USUARIO = "";
        public string CONTRA = "";
        public string BASE = "";
        
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
            FRMUSUARIO.SERVIDOR = this.BASE;
            FRMUSUARIO.Show();
            //this.Visible = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            TMRJUEGO.Start();
            lblMostarUsuario.Text = USUARIO;
            lblMOSTARCONTRA.Text = CONTRA;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

           
            CONEXIONBD.Servidor = this.BASE; //ANGEL - PC\SQLEXPRESS
            CONEXIONBD.Base_Datos = "FAKE_STEAM";
            CONEXIONBD.Usuario = this.USUARIO;
            CONEXIONBD.Contraseña = this.CONTRA;
            CONEXIONBD DB = new CONEXIONBD();
            DB.Conectar();
            string cadena = " SELECT PRECIO FROM JUEGOS WHERE NOMBRE=" + "'" + cmbJuegos.Text + "'";
            DataTable NUEVO = new DataTable();
            NUEVO = DB.EjecutarConsulta(new SqlCommand(cadena));
            DB.CerrarConexion();
            lblMOSTARPRECIO.Text = NUEVO.Rows[0]["PRECIO"].ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            TMRJUEGO.Stop();
        }

        private void btnAGREGARALALISTA_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdministrarJuegos FRMJUEGOS = new AdministrarJuegos();
            FRMJUEGOS.CONTRA = this.CONTRA;
            FRMJUEGOS.USAURIO = this.USUARIO;
            FRMJUEGOS.SERVIDOR = this.BASE;
            FRMJUEGOS.Show();
        }

        private void btnAdministrarJuegos_Click(object sender, EventArgs e)
        {
            AdministrarJuegos FRMJUEGOS = new AdministrarJuegos();
            FRMJUEGOS.CONTRA = this.CONTRA;
            FRMJUEGOS.USAURIO = this.USUARIO;
            FRMJUEGOS.SERVIDOR = this.BASE;
            FRMJUEGOS.Show();
        }

        private void cmbJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TMRJUEGO.Start();
        }
        public void resetear()
        {
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
