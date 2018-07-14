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
            try
            {
                CONEXIONBD.Servidor = "ANGEL-PC\\SQLEXPRESS"; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();     
                SqlCommand comando = new SqlCommand("AGREGAR_USUARIO2");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOMBREDELPERFIL",txtNOMBREPERFIL.Text);
                comando.Parameters.AddWithValue("@APPATERNO", txtAPELLIDOPATERNO.Text);
                comando.Parameters.AddWithValue("@APMATERNO", txtAPELLIDOMATERNO.Text);
                comando.Parameters.AddWithValue("@NOMBRE", txtNOMBRE.Text);
                comando.Parameters.AddWithValue("@FECHANACIMIENTO", dtpNACIMIENTO.Value.Month+"-"+dtpNACIMIENTO.Value.Day+"-"+dtpNACIMIENTO.Value.Year); //"2007/12/1"
                comando.Parameters.AddWithValue("@CORREO", txtCORREO.Text);
                comando.Parameters.AddWithValue("@DESCRIPCION", txtDESCPRIPCION.Text);
                comando.Parameters.AddWithValue("@PAIS", cmbPAIS.Text);
                comando.Parameters.AddWithValue("@ESTADO", cmbESTADO.Text);
                comando.Parameters.AddWithValue("@CIUDAD", cmbCIUDAD.Text);                
                comando.Parameters.AddWithValue("@UBICACIONIMAGEN", picIMAGEN.ImageLocation.ToString());
                DB.AbrirConexion();
                DB.EjecutarComando(comando);
                DB.CerrarConexion();

                MessageBox.Show("SE AGREGO UN NUEVO USUARIO");
                this.LimpiarDatos();



            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            
           



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

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(dtpNACIMIENTO.Value.Month + "-" + dtpNACIMIENTO.Value.Day + "-" + dtpNACIMIENTO.Value.Year);
        }
        public void LimpiarDatos()  //Metodo local que limpia los datos
        {

           // foreach (Control x in grpDatos.Controls)
             //   if (x is TextBox)
               //     x.Text = "";
            foreach (Control x in grpPERFIL.Controls)
                if (x is TextBox)
                    x.Text = "";
            foreach (Control x in grpPERSONAL.Controls)
                if (x is TextBox)
                    x.Text = "";
            foreach (Control x in grpPERSONAL.Controls)
                if (x is TextBox)
                    x.Text = "";

        }
    }
}
