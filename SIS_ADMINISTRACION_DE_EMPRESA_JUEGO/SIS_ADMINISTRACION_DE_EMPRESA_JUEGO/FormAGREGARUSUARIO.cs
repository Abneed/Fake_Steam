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
    public partial class FormAGREGARUSUARIO : Form
    {
        public string imgLoc = "C:\\Users\\Angel\\Pictures\\Usuario.jpg";
        frmPrincipal miprincipal = new frmPrincipal();
        public string CONTRA = "";
         public string USAURIO = "";
        public FormAGREGARUSUARIO()
        {
            InitializeComponent();
        }
        ~ FormAGREGARUSUARIO()
        {
       
            this.Dispose();
        }
        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                
                OpenFileDialog DLG = new OpenFileDialog();
                DLG.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                DLG.Title = "seleciona la imagen del usuario";
                if (DLG.ShowDialog()==DialogResult.OK)
                {
                    imgLoc = DLG.FileName.ToString();
                    picIMAGEN.ImageLocation = imgLoc;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
        }

        private void FormAGREGARUSUARIO_Load(object sender, EventArgs e)
        {
            picIMAGEN.ImageLocation = imgLoc;
            try
            {

           
            CONEXIONBD.Servidor = "ANGEL-PC\\SQLEXPRESS"; //ANGEL - PC\SQLEXPRESS
            CONEXIONBD.Base_Datos = "FAKE_STEAM";
            CONEXIONBD.Usuario = this.USAURIO;
            CONEXIONBD.Contraseña = this.CONTRA;
            CONEXIONBD DB = new CONEXIONBD();
            DB.Conectar();
                cmbPAIS.DisplayMember = "NOMBRE";
                cmbPAIS.DataSource = DB.EjecutarConsulta(new SqlCommand("SELECT NOMBRE FROM PAIS"));            
                DB.CerrarConexion();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
           // frmPrincipal mi = new frmPrincipal();
            //mi.Visible = true;
            this.Dispose();
           

        }

        private void cmbPAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cmbESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = "ANGEL-PC\\SQLEXPRESS"; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();
                DB.Conectar();
                string cadena = "select ES.NOMBRE from ESTADO AS ES JOIN PAIS_ESTADO AS PAISESTADO ON(ES.IDESTADO = PAISESTADO.IDESTADO) JOIN PAIS AS PAIS ON(PAISESTADO.IDPAIS = PAIS.IDPAIS) WHERE PAIS.NOMBRE = " +"'" +cmbPAIS.Text+"'";
                cmbESTADO.DisplayMember = "NOMBRE";
                cmbESTADO.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                DB.CerrarConexion();
                timer2.Start();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
           
            timer1.Stop();
        }

        private void btnAGREGARUSUARIO_Click(object sender, EventArgs e)
        {
            /* SqlCommand comando = new SqlCommand("AGREGAR_HOSPEDAJES");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@HABITACION", cbHabitacion.Text);
                comando.Parameters.AddWithValue("@RESERVA", cbCliente.Text);
                
                BD.AbrirConexion();
                BD.EjecutarComando(comando);
                BD.CerrarConexion();
                MostrarDatosEnDGVRESERVAS2();
                MessageBox.Show("Se ha agregado un nuevo Hospedaje.", "Registro de Hospedaje");*/



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = "ANGEL-PC\\SQLEXPRESS"; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();
                DB.Conectar();
                string cadena = "select CI.NOMBRE  from CIUDAD AS CI JOIN ESTADO_CIUDAD AS ESTCIU ON(ESTCIU.IDCIUDAD=CI.IDCIUDAD) JOIN ESTADO AS EST ON(EST.IDESTADO=ESTCIU.IDESTADO) WHERE EST.NOMBRE=" + "'" + cmbESTADO.Text + "'";
                cmbCIUDAD.DisplayMember = "NOMBRE";
                cmbCIUDAD.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                DB.CerrarConexion();
                
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            timer1.Stop();
            timer2.Stop();
        }
    }
}
