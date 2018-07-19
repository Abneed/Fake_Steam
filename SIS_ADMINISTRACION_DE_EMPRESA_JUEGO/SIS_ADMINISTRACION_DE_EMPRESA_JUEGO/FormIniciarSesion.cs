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
    public partial class FormIniciarSesion : Form
    {

        public FormIniciarSesion()
        {
            InitializeComponent();
            ConexionBD.Servidor = "DESKTOP-ABNEED";
            ConexionBD.BaseDatos = "FAKE_STEAM";
        }
        
        ~FormIniciarSesion()
        {
            this.Dispose();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.Usuario = txtUsuario.Text.ToUpper();
                ConexionBD.Contraseña = txtContra.Text;
                ConexionBD DB = new ConexionBD();

                DB.Conectar();

                FormPrincipal formPrincipal = new FormPrincipal();

                string cadena = " select NOMBRE from JUEGOS";
                formPrincipal.cmbJuegos.DisplayMember = "NOMBRE";
                formPrincipal.cmbJuegos.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));

                string cadenausuarios = " select NOMBREPERFIL from USUARIOS";
                formPrincipal.cmbUsuarios.DisplayMember = "NOMBREPERFIL";
                formPrincipal.cmbUsuarios.DataSource = DB.EjecutarConsulta(new SqlCommand(cadenausuarios));

                string cadenaDESCRIPCION = " SELECT DESCRIPCION FROM METODOPAGO";
                formPrincipal.cmbMETODODEPAGO.DisplayMember = "DESCRIPCION";
                formPrincipal.cmbMETODODEPAGO.DataSource = DB.EjecutarConsulta(new SqlCommand(cadenaDESCRIPCION));

                formPrincipal.Show();
                this.Visible = false;
                DB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
