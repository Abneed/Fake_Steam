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
        public int control = 0;
        List<JUEGO> MILISTA = new List<JUEGO>();
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
            dgvJuegos.DataSource = MILISTA;
            if (USUARIO == "USUARIO")
            {
                btnAdministraGenero.Visible = false;
                btnAdministrarSistemaOperativo.Visible = false;
                btnAdministrarMetodosDePago.Visible = false;
                btnAdministrarUbicaciones.Visible = false;
                btnAdministrarJuegos.Visible = false;
                btnReporteDeVentas.Visible = false;

            }
            if (USUARIO=="ADMINISTRADOR")
            {
                btnAdministraGenero.Visible = false;
                btnAdministrarSistemaOperativo.Visible = false;
                btnAdministrarMetodosDePago.Visible = false;
                btnAdministrarUbicaciones.Visible = false;
                btnAdministrarJuegos.Visible = true;
                btnReporteDeVentas.Visible = false;
            }
            if (USUARIO=="JEFE")
            {
                btnAdministraGenero.Visible = false;
                btnAdministrarSistemaOperativo.Visible = false;
                btnAdministrarMetodosDePago.Visible = false;
                btnAdministrarUbicaciones.Visible = false;
                btnAdministrarJuegos.Visible = true;
                btnReporteDeVentas.Visible = true;
            }
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
            string cadena = " SELECT PRECIO,CANTIDAD FROM JUEGOS WHERE NOMBRE=" + "'" + cmbJuegos.Text + "'";
            DataTable NUEVO = new DataTable();
            NUEVO = DB.EjecutarConsulta(new SqlCommand(cadena));
            DB.CerrarConexion();
            lblMOSTARPRECIO.Text = NUEVO.Rows[0]["PRECIO"].ToString();
                int CONTROL = 0;
                foreach (JUEGO MI in MILISTA)
                {
                    if (MI.NOMBRE==cmbJuegos.Text)
                    {
                        lblCANTIDADEXISTENCIA.Text = NUEVO.Rows[0]["CANTIDAD"].ToString();
                        lblCANTIDADEXISTENCIA.Text = (int.Parse(lblCANTIDADEXISTENCIA.Text) - MI.CANTIDAD).ToString();
                        CONTROL++;
                    }

                }
                if (CONTROL==0)
                {
                    lblCANTIDADEXISTENCIA.Text = NUEVO.Rows[0]["CANTIDAD"].ToString();
                }
           // lblCANTIDADEXISTENCIA.Text= NUEVO.Rows[0]["CANTIDAD"].ToString();
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
            JUEGO MI = new JUEGO();
            MI.NOMBRE = cmbJuegos.Text;
            MI.PRECIOPORUNIDAD = double.Parse(lblMOSTARPRECIO.Text);
            MI.CANTIDAD = 1;
            if (int.Parse(lblCANTIDADEXISTENCIA.Text)<=0)
            {
                MessageBox.Show("SIN UNIDADES DISPONIBLES");
            }
            else
            {
                    
            
            if (control==0)
            {
                MILISTA.Add(MI);
                control++;
            }
            else
            {

                    int APUNTADOR = 0;
            foreach (JUEGO mijuegolocal in MILISTA)
            {
                if (mijuegolocal.NOMBRE == MI.NOMBRE)
                {

                    MI.CANTIDAD = mijuegolocal.CANTIDAD + 1;
                    MILISTA.Remove(mijuegolocal);
                    MILISTA.Add(MI);
                     APUNTADOR++;
                    break;
                    
                }
                
            }
                    if (APUNTADOR==0)
                    {
                        MILISTA.Add(MI);
                    }

            }
            dgvJuegos.Refresh();
            dgvJuegos.DataSource = null;
            dgvJuegos.DataSource = MILISTA;
            dgvJuegos.Refresh();
            tmrTotal.Start();
                TMRJUEGO.Start();

            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            dgvJuegos.DataSource = null;
            dgvJuegos.Refresh();
            MILISTA.Clear();
            tmrTotal.Start();
            TMRJUEGO.Start();
            lblIVA.Text = "0";
            lblsubTOTAL.Text="0";
            lblMostraTotal.Text = "0";
        }

        private void tmrTotal_Tick(object sender, EventArgs e)
        {
            double precio = 0;
            double xs = 0.0;
            try
            {
                foreach (JUEGO MIJUEGOLOCAL in MILISTA)
                {
                    xs = MIJUEGOLOCAL.PRECIOPORUNIDAD * MIJUEGOLOCAL.CANTIDAD;
                    precio = precio + xs;
                    lblsubTOTAL.Text = precio.ToString();
                    lblIVA.Text = (precio * 0.16).ToString();
                    lblMostraTotal.Text = ((double.Parse(lblsubTOTAL.Text)) + (double.Parse(lblIVA.Text))).ToString(); lblsubTOTAL.Text = precio.ToString();
                    lblIVA.Text = (precio * 0.16).ToString();
                    lblMostraTotal.Text = ((double.Parse(lblsubTOTAL.Text)) + (double.Parse(lblIVA.Text))).ToString();

                }
           /* for (int i = 0; i < dgvJuegos.RowCount-1; i++)
            {
             

                    xs =double.Parse(dgvJuegos[1, i].Value.ToString())*double.Parse(dgvJuegos[2, i].Value.ToString());
                precio = precio + xs;//double.Parse(xs);
                lblsubTOTAL.Text = precio.ToString() ;
                lblIVA.Text = (precio * 0.16).ToString() ;
                    lblMostraTotal.Text = ((double.Parse(lblsubTOTAL.Text)) + (double.Parse(lblIVA.Text))).ToString();
            }*/
            }
            catch (Exception ex)
            {
                tmrTotal.Stop();
                return;
            }
            tmrTotal.Stop();
            // break;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = BASE; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USUARIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                foreach (JUEGO MI in MILISTA)
                {
                    CONEXIONBD DB = new CONEXIONBD();
                    SqlCommand comando = new SqlCommand("VENTA");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@METODODEPAGO", cmbMETODODEPAGO.Text);
                    comando.Parameters.AddWithValue("@NOMBREUSUARIO", cmbUsuarios.Text);
                    comando.Parameters.AddWithValue("@PRECIO", MI.PRECIOPORUNIDAD);
                    comando.Parameters.AddWithValue("@NOMBREJUEGO",MI.NOMBRE );
                    comando.Parameters.AddWithValue("@CANTIDAD", MI.CANTIDAD);
                    DB.AbrirConexion();
                    DB.EjecutarComando(comando);
                    DB.CerrarConexion();
                }
                
                MessageBox.Show("VENTA REGISTRADA CORRECTAMENTE");

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            MILISTA.Clear();
            dgvJuegos.DataSource = null;
            dgvJuegos.Refresh();
            TMRJUEGO.Start();
            tmrTotal.Start();
            lblIVA.Text = "0";
            lblsubTOTAL.Text = "0";
            lblMostraTotal.Text = "0";
        }

        private void grpVentas_Enter(object sender, EventArgs e)
        {

        }

        private void btnReporteDeVentas_Click(object sender, EventArgs e)
        {
            REPORTES mireporte = new REPORTES();
            mireporte.BASE = this.BASE;
            mireporte.USUARIO = this.USUARIO;
            mireporte.CONTRA = this.CONTRA;
            mireporte.Show();
            

        }
    }
}
