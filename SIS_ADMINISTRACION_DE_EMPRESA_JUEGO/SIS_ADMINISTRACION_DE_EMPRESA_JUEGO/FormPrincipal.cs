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
    public partial class FormPrincipal : Form
    {
        private int m_intControl = 0;
        private ConexionBD m_connFakeSteamBD = new ConexionBD();
        private List<VideoJuego> m_lstMiLista = new List<VideoJuego>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        ~FormPrincipal()
        {
            this.Dispose();
        }

        //private void ConfiguracionPredeterminada()
        //{
        //    btnAdministraGenero.Visible = false;
        //    btnAdministrarSistemaOperativo.Visible = false;
        //    btnAdministrarMetodosDePago.Visible = false;
        //    btnAdministrarUbicaciones.Visible = false;
        //    btnAdministrarJuegos.Visible = false;
        //    btnReporteDeVentas.Visible = false;
        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormIniciarSesion formIniciarSesion = new FormIniciarSesion();
            formIniciarSesion.Visible = true;
            this.Dispose();
        }

        private void btnAGREGARUSUARIO_Click(object sender, EventArgs e)
        {
            FormAdministradorUsuarios frmAdminUsuarios = new FormAdministradorUsuarios();
            frmAdminUsuarios.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            TMRJUEGO.Start();
            lblMostarUsuario.Text = ConexionBD.Usuario;
            lblMOSTARCONTRA.Text = ConexionBD.Contraseña;

            dgvJuegos.DataSource = this.m_lstMiLista;

            //switch (ConexionBD.Usuario)
            //{
            //    case "USUARIO":
            //        ConfiguracionPredeterminada();
            //        break;
            //    case "ADMINISTRADOR":
            //        ConfiguracionPredeterminada();
            //        btnAdministrarJuegos.Visible = true;
            //        break;
            //    case "JEFE":
            //        ConfiguracionPredeterminada();
            //        btnAdministrarJuegos.Visible = true;
            //        btnReporteDeVentas.Visible = true;
            //        break;
            //    default:
            //        // throw new Exception("Tipo de usuario indefinido.");
            //        break;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                m_connFakeSteamBD.Conectar();
                string cadena = " SELECT PRECIO, CANTIDAD FROM JUEGOS WHERE NOMBRE=" + "'" + cmbJuegos.Text + "'";
                DataTable NUEVO = new DataTable();
                NUEVO = m_connFakeSteamBD.EjecutarConsulta(new SqlCommand(cadena));
                m_connFakeSteamBD.CerrarConexion();
                lblMOSTARPRECIO.Text = NUEVO.Rows[0]["PRECIO"].ToString();
                int intControl = 0;
                foreach (VideoJuego juego in m_lstMiLista)
                {
                    if (juego.Nombre == cmbJuegos.Text)
                    {
                        lblCANTIDADEXISTENCIA.Text = NUEVO.Rows[0]["CANTIDAD"].ToString();
                        lblCANTIDADEXISTENCIA.Text = (int.Parse(lblCANTIDADEXISTENCIA.Text) - juego.Cantidad).ToString();
                        intControl++;
                    }

                }
                if (intControl == 0)
                {
                    lblCANTIDADEXISTENCIA.Text = NUEVO.Rows[0]["CANTIDAD"].ToString();
                }
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
            VideoJuego juego = new VideoJuego();
            juego.Nombre = cmbJuegos.Text;
            juego.PrecioPorUnidad = double.Parse(lblMOSTARPRECIO.Text);
            juego.Cantidad = 1;

            if (int.Parse(lblCANTIDADEXISTENCIA.Text) <= 0)
            {
                MessageBox.Show("SIN UNIDADES DISPONIBLES");
            }
            else
            {
                if (m_intControl == 0)
                {
                    m_lstMiLista.Add(juego);
                    m_intControl++;
                }
                else
                {

                    int APUNTADOR = 0;
                    foreach (VideoJuego mijuegolocal in m_lstMiLista)
                    {
                        if (mijuegolocal.Nombre == juego.Nombre)
                        {

                            juego.Cantidad = mijuegolocal.Cantidad + 1;
                            m_lstMiLista.Remove(mijuegolocal);
                            m_lstMiLista.Add(juego);
                            APUNTADOR++;
                            break;

                        }

                    }
                    if (APUNTADOR == 0)
                    {
                        m_lstMiLista.Add(juego);
                    }

                }
                dgvJuegos.Refresh();
                dgvJuegos.DataSource = null;
                dgvJuegos.DataSource = m_lstMiLista;
                dgvJuegos.Refresh();
                tmrTotal.Start();
                TMRJUEGO.Start();
            }
        }

        private void btnAdministrarJuegos_Click(object sender, EventArgs e)
        {
            FormAdministradorJuegos frmAdministradorJuegos = new FormAdministradorJuegos();
            frmAdministradorJuegos.Show();
        }

        private void cmbJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TMRJUEGO.Start();
        }

        // Boton DECLINAR
        private void button1_Click(object sender, EventArgs e)
        {
            dgvJuegos.DataSource = null;
            dgvJuegos.Refresh();
            m_lstMiLista.Clear();
            tmrTotal.Start();
            TMRJUEGO.Start();
            lblIVA.Text = "0";
            lblsubTOTAL.Text = "0";
            lblMostraTotal.Text = "0";
        }

        // Boton COMPRAR
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("VENTA");

                m_connFakeSteamBD.AbrirConexion();

                foreach (VideoJuego juego in m_lstMiLista)
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@METODODEPAGO", cmbMETODODEPAGO.Text);
                    comando.Parameters.AddWithValue("@NOMBREUSUARIO", cmbUsuarios.Text);
                    comando.Parameters.AddWithValue("@PRECIO", juego.PrecioPorUnidad);
                    comando.Parameters.AddWithValue("@NOMBREJUEGO", juego.Nombre);
                    comando.Parameters.AddWithValue("@CANTIDAD", juego.Cantidad);
                    m_connFakeSteamBD.EjecutarComando(comando);
                }

                m_connFakeSteamBD.CerrarConexion();

                MessageBox.Show("VENTA REGISTRADA CORRECTAMENTE");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            m_lstMiLista.Clear();
            dgvJuegos.DataSource = null;
            dgvJuegos.Refresh();
            TMRJUEGO.Start();
            tmrTotal.Start();
            lblIVA.Text = "0";
            lblsubTOTAL.Text = "0";
            lblMostraTotal.Text = "0";
        }

        private void tmrTotal_Tick(object sender, EventArgs e)
        {
            double dblSubTotal = 0.0;
            double dblImporte = 0.0;

            try
            {
                foreach (VideoJuego juego in m_lstMiLista)
                {
                    dblImporte = juego.PrecioPorUnidad * juego.Cantidad;
                    dblSubTotal += dblImporte;
                }
                lblsubTOTAL.Text = dblSubTotal.ToString();
                lblIVA.Text = (dblSubTotal * 0.16).ToString();
                lblMostraTotal.Text = ((double.Parse(lblsubTOTAL.Text)) + (double.Parse(lblIVA.Text))).ToString();
            }
            catch (Exception ex)
            {
                tmrTotal.Stop();
                return;
            }
            tmrTotal.Stop();
        }

        private void grpVentas_Enter(object sender, EventArgs e)
        {

        }

        private void btnReporteDeVentas_Click(object sender, EventArgs e)
        {
            FormReportes mireporte = new FormReportes();
            mireporte.Show();
        }
    }
}
