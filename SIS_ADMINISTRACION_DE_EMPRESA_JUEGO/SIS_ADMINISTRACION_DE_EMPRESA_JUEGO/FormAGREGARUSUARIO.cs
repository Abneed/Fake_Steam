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
        public string SERVIDOR = "";
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
            radAgregar.Checked = true;
            try
            {

           
            CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
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
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
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
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
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
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (radAgregar.Checked==true)
            {
                grpDATOS.Visible = true;
                grpEliminar.Visible = false;
                btnAGREGARUSUARIO.Visible = true;
                btnACTUALIZARUSUARIO.Visible = false;
                grpActualizar.Visible = false;
                grpUbicacion.Visible = true;
                grpMOSTARUBICACION.Visible = false;
                chkUBICACION.Visible = false;
                grpIDUsuario.Visible = false;

            }
            
        }

        private void radEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (radEliminar.Checked==true)
            {
                grpDATOS.Visible = false;
                grpEliminar.Visible = true;
                tmrEliminar.Start();
                grpIDUsuario.Visible = false;
            }
        }

        private void tmrEliminar_Tick(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();
                DB.Conectar();
                string cadena = " SELECT NOMBREPERFIL  FROM USUARIOS";
                cmbPerfiles.DisplayMember = "NOMBREPERFIL";
                cmbPerfiles.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                DB.CerrarConexion();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            tmrEliminar.Stop();
        }

        private void radActualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (radActualizar.Checked==true)
            {
                grpEliminar.Visible = false;
                btnAGREGARUSUARIO.Visible = false;
                btnACTUALIZARUSUARIO.Visible = true;
                grpDATOS.Visible = true;
                grpActualizar.Visible = true;
                tmrActualizar.Start();
                grpUbicacion.Visible = false;
                grpMOSTARUBICACION.Visible = true;
                chkUBICACION.Visible = true;
                grpIDUsuario.Visible = true;

            }
        }

        private void btnBuscarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();
                DB.Conectar();
                string cadena = "select US.NOMBREPERFIL,US.APPATERNO,US.APMATERNO,US.NOMBRE,US.FECHANACIMIENTO,US.CORREOELECTRONICO,US.DESCRIPCION,PA.NOMBRE AS PAIS,EST.NOMBRE AS ESTADO,CIU.NOMBRE AS CIUDAD,IM.UBICACIONIMAGEN,US.IDUSUARIO from USUARIOS AS US JOIN PAIS AS PA ON(PA.IDPAIS=US.IDPAIS) JOIN ESTADO AS EST ON(EST.IDESTADO=US.IDESTADO) JOIN CIUDAD AS CIU ON(CIU.IDCIUDAD=US.IDCIUDAD) JOIN IMAGENES AS IM  ON(IM.IDIMAGEN=US.IDIMAGEN) where US.NOMBREPERFIL=" + "'"+cmbSeleccionarUsuario.Text+"'";
                DataTable NUEVO = new DataTable();
                NUEVO = DB.EjecutarConsulta(new SqlCommand(cadena));
                DB.CerrarConexion();
                txtNOMBREPERFIL.Text = NUEVO.Rows[0]["NOMBREPERFIL"].ToString();
                txtAPELLIDOPATERNO.Text= NUEVO.Rows[0]["APPATERNO"].ToString();
                txtAPELLIDOMATERNO.Text= NUEVO.Rows[0]["APMATERNO"].ToString();
                txtNOMBRE.Text= NUEVO.Rows[0]["NOMBRE"].ToString();
                dtpNACIMIENTO.Value= DateTime.Parse( NUEVO.Rows[0]["FECHANACIMIENTO"].ToString());
                txtCORREO.Text= NUEVO.Rows[0]["CORREOELECTRONICO"].ToString();
               txtDESCPRIPCION.Text= NUEVO.Rows[0]["DESCRIPCION"].ToString();

                /*int index = cmbPAIS.FindString(NUEVO.Rows[0]["PAIS"].ToString());
                cmbPAIS.SelectedIndex = index;*/
                lblMostrarPais.Text = NUEVO.Rows[0]["PAIS"].ToString();
                //cmbPAIS.SelectedIndex= int.Parse(NUEVO.Rows[0]["PAIS"].ToString())-1;
                /*index = cmbESTADO.FindString(NUEVO.Rows[0]["ESTADO"].ToString());
                cmbESTADO.SelectedIndex = index;//int.Parse(NUEVO.Rows[0]["ESTADO"].ToString())-1;*/
               lblMostrarEstado.Text = NUEVO.Rows[0]["ESTADO"].ToString();
                /* index = cmbESTADO.FindString(NUEVO.Rows[0]["CIUDAD"].ToString());
                 cmbCIUDAD.SelectedIndex = index; //int.Parse(NUEVO.Rows[0]["CIUDAD"].ToString())-1;*/
               lblMostrarCiudad.Text = NUEVO.Rows[0]["CIUDAD"].ToString();

                picIMAGEN.ImageLocation= NUEVO.Rows[0]["UBICACIONIMAGEN"].ToString();
                lblMOSTARIDUSUARIO.Text= NUEVO.Rows[0]["IDUSUARIO"].ToString();
                
               // picIMAGEN.Refresh();
                
                
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            
        }

        private void tmrActualizar_Tick(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();
                DB.Conectar();
                string cadena = " SELECT NOMBREPERFIL  FROM USUARIOS";
                cmbSeleccionarUsuario.DisplayMember = "NOMBREPERFIL";
                cmbSeleccionarUsuario.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                DB.CerrarConexion();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            tmrActualizar.Stop();
        }

        private void chkUBICACION_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUBICACION.Checked==true)
            {
                grpUbicacion.Visible = true;
            }
            else
            {
                grpUbicacion.Visible = false;
            }
        }

        private void btnACTUALIZARUSUARIO_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                CONEXIONBD.Base_Datos = "FAKE_STEAM";
                CONEXIONBD.Usuario = this.USAURIO;
                CONEXIONBD.Contraseña = this.CONTRA;
                CONEXIONBD DB = new CONEXIONBD();
                SqlCommand comando = new SqlCommand("MODIFICAR_USUARIO2");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOMBREDELPERFIL", txtNOMBREPERFIL.Text);
                comando.Parameters.AddWithValue("@APPATERNO", txtAPELLIDOPATERNO.Text);
                comando.Parameters.AddWithValue("@APMATERNO", txtAPELLIDOMATERNO.Text);
                comando.Parameters.AddWithValue("@NOMBRE", txtNOMBRE.Text);
                comando.Parameters.AddWithValue("@FECHANACIMIENTO", dtpNACIMIENTO.Value.Month + "-" + dtpNACIMIENTO.Value.Day + "-" + dtpNACIMIENTO.Value.Year); //"2007/12/1"
                comando.Parameters.AddWithValue("@CORREO", txtCORREO.Text);
                comando.Parameters.AddWithValue("@DESCRIPCION", txtDESCPRIPCION.Text);
                if (chkUBICACION.Checked==true)
                {
                    comando.Parameters.AddWithValue("@PAIS", cmbPAIS.Text);
                    comando.Parameters.AddWithValue("@ESTADO", cmbESTADO.Text);
                    comando.Parameters.AddWithValue("@CIUDAD", cmbCIUDAD.Text);
                }
                else
                {
                    comando.Parameters.AddWithValue("@PAIS", lblMostrarPais.Text);
                    comando.Parameters.AddWithValue("@ESTADO", lblMostrarEstado.Text);
                    comando.Parameters.AddWithValue("@CIUDAD", lblMostrarCiudad.Text);
                }                
                comando.Parameters.AddWithValue("@UBICACIONIMAGEN", picIMAGEN.ImageLocation.ToString());
                comando.Parameters.AddWithValue("@IDPERFIL",lblMOSTARIDUSUARIO.Text);
                DB.AbrirConexion();
                DB.EjecutarComando(comando);
                DB.CerrarConexion();

                MessageBox.Show("SE MODIFICO USUARIO TAL:"+cmbSeleccionarUsuario.Text);
                this.LimpiarDatos();



            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            tmrActualizar.Start();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro De Eliminar a El Usuario: " + cmbPerfiles.Text + "?"+"\n no se podra recuperar", "Elimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //no quiso
                
                return;
            }
            else
            {
                //si quiso
                try
                {
                    CONEXIONBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                    CONEXIONBD.Base_Datos = "FAKE_STEAM";
                    CONEXIONBD.Usuario = this.USAURIO;
                    CONEXIONBD.Contraseña = this.CONTRA;
                    CONEXIONBD DB = new CONEXIONBD();
                    SqlCommand comando = new SqlCommand("ELIMINAR_USUARIO2");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOMBRE", cmbPerfiles.Text);
                    DB.AbrirConexion();
                    DB.EjecutarComando(comando);
                    DB.CerrarConexion();

                    MessageBox.Show("SE ELIMINO USUARIO :" + cmbPerfiles.Text);
                    this.LimpiarDatos();
                    tmrEliminar.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void cmbSeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}
