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
    public partial class FormAdministrarJuegos : Form
    {
        public FormAdministrarJuegos()
        {
            InitializeComponent();
        }
        ConexionBD DB = new ConexionBD();
        FormPrincipal miprincipalJuegos = new FormPrincipal();
        
        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (radNuevoJuego.Enabled == true)
            {
                try
                {
                    //ConexionBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                    //ConexionBD.BaseDatos = "FAKE_STEAM";
                    //ConexionBD.Usuario = this.USAURIO;
                    //ConexionBD.Contraseña = this.CONTRA;
                    //ConexionBD DB = new ConexionBD();
                    SqlCommand comando = new SqlCommand("AGREGAR_JUEGO");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOMBRE", txtNombreJuego.Text);
                    comando.Parameters.AddWithValue("@FECHALANZAMIENTO", dtpJuegoLanzamiento.Value.Month + "-" + dtpJuegoLanzamiento.Value.Day + "-" + dtpJuegoLanzamiento.Value.Year); //"2007/12/1"
                    comando.Parameters.AddWithValue("@NOMBREDESARROLLADOR", cmbDesarrolladorJuego.Text);
                    comando.Parameters.AddWithValue("@NOMBRECLASIFICACION", cmbClasificacionJuego.Text);
                    comando.Parameters.AddWithValue("@NOMBREDISTRIBUIDOR", cmbDistribuidores.Text);
                    comando.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                    comando.Parameters.AddWithValue("@CANTIDAD", int.Parse(txtCantidad.Text));
                    DB.AbrirConexion();
                    DB.EjecutarComando(comando);
                    string cadena = " SELECT NOMBRE  FROM JUEGOS";
                    cmbJuegoSeleccion.DisplayMember = "NOMBREJUEGOS";
                    cmbJuegoSeleccion.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));

                    DB.CerrarConexion();

                    MessageBox.Show("SE AGREGO UN NUEVO JUEGO");
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                    return;
                }
                this.LimpiarDatos();
            }
        }

        private void AdministrarJuegos_Load(object sender, EventArgs e)
        {
            radNuevoJuego.Checked = true;
            Timer1.Start();
            
        }

        private void btnBuscarJuego_Click(object sender, EventArgs e)
        {
            try
            {
                //ConexionBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                //ConexionBD.BaseDatos = "FAKE_STEAM";
                //ConexionBD.Usuario = this.USAURIO;
                //ConexionBD.Contraseña = this.CONTRA;
                //ConexionBD DB = new ConexionBD();
                DB.AbrirConexion();
                string cadena = "SELECT JUE.NOMBRE,JUE.FECHALANZAMIENTO AS FECHA,DES.NOMBRE AS DESARROLLADOR,CLA.NOMBRE AS CLASIFICACION,DIS.NOMBRE AS DISTRIBUIDOR,JUE.PRECIO,JUE.IDJUEGO,JUE.CANTIDAD as cantidad FROM JUEGOS AS JUE  JOIN DESARROLLADORES AS DES ON(JUE.IDDESARROLLADORES=DES.IDDESARROLLADOR) JOIN CLASIFICACIONES AS CLA ON(JUE.IDCLASIFICACION=CLA.IDCLASIFICACION) JOIN DISTRIBUIDORES AS DIS  ON(JUE.IDDISTRIBUIDOR=DIS.IDDISTRIBUIDOR) WHERE JUE.NOMBRE= " + "'" + cmbJuegoSeleccion.Text + "'";
                DataTable NUEVO = new DataTable();
                NUEVO = DB.EjecutarConsulta(new SqlCommand(cadena));
                DB.CerrarConexion();
                txtNombreJuego.Text = NUEVO.Rows[0]["NOMBRE"].ToString();
                cmbClasificacionJuego.Text = NUEVO.Rows[0]["CLASIFICACION"].ToString();
                cmbDesarrolladorJuego.Text = NUEVO.Rows[0]["DESARROLLADOR"].ToString();
                cmbDistribuidores.Text = NUEVO.Rows[0]["DISTRIBUIDOR"].ToString();
                txtPrecio.Text = NUEVO.Rows[0]["PRECIO"].ToString();               
                dtpJuegoLanzamiento.Value = DateTime.Parse(NUEVO.Rows[0]["FECHA"].ToString());
                lblMOSTARJUEGO.Text = NUEVO.Rows[0]["IDJUEGO"].ToString();
                txtCantidad.Text= NUEVO.Rows[0]["CANTIDAD"].ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormPrincipal asd = new FormPrincipal();
            // asd.resetear();
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        public void LimpiarDatos()
        {
            foreach (Control x in grpDatos.Controls)
                if (x is TextBox)
                    x.Text = "";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //ConexionBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                //ConexionBD.BaseDatos = "FAKE_STEAM";
                //ConexionBD.Usuario = this.USAURIO;
                //ConexionBD.Contraseña = this.CONTRA;
                //ConexionBD DB = new ConexionBD();
                DB.Conectar();
                string cadena = "SELECT NOMBRE FROM JUEGOS";
                cmbJuegoSeleccion.DisplayMember = "NOMBRE";
                cmbJuegoSeleccion.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                cadena = "SELECT NOMBRE FROM  DESARROLLADORES";
                cmbDesarrolladorJuego.DisplayMember = "NOMBRE";
                cmbDesarrolladorJuego.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                cadena = "SELECT NOMBRE FROM  DISTRIBUIDORES";
                cmbDistribuidores.DisplayMember = "NOMBRE";
                cmbDistribuidores.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                cadena = "SELECT NOMBRE FROM CLASIFICACIONES";
                cmbClasificacionJuego.DisplayMember = "NOMBRE";
                cmbClasificacionJuego.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return;
            }
            Timer1.Stop();
        }

        private void radNuevoJuego_CheckedChanged(object sender, EventArgs e)
        {
            if (radNuevoJuego.Checked==true)
            {
                radActualizarJuego.Checked = false;
                radBorrarJuego.Checked = false;
                grpDatos.Visible = true;
                btnAccion.Visible = true;
                btnELIMINAR.Visible = false;
                btnBuscarJuego.Visible = false;
                grpEliminar.Visible = false;
                btnActualizar.Visible = false;
                
            }
           
        }

        private void radBorrarJuego_CheckedChanged(object sender, EventArgs e)
        {
            if (radBorrarJuego.Checked==true)
            {
                radNuevoJuego.Checked = false;
                radActualizarJuego.Checked = false;
                grpDatos.Visible = false;
                grpEliminar.Visible = true;
                btnELIMINAR.Visible = true;
                btnBuscarJuego.Visible = false;
                

            }
            
        }

        private void radActualizarJuego_CheckedChanged(object sender, EventArgs e)
        {
            if (radActualizarJuego.Checked==true)
            {
                grpDatos.Visible = true;
                grpEliminar.Visible = true;
                radBorrarJuego.Checked = false;
                radNuevoJuego.Checked = false;
               
                btnAccion.Visible = false;
                btnELIMINAR.Visible = false;
                btnBuscarJuego.Visible = true;
                btnELIMINAR.Visible = false;
                btnActualizar.Visible = true;
                
            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (radNuevoJuego.Enabled == true)
            {
                try
                {
                    //ConexionBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                    //ConexionBD.BaseDatos = "FAKE_STEAM";
                    //ConexionBD.Usuario = this.USAURIO;
                    //ConexionBD.Contraseña = this.CONTRA;
                    //ConexionBD DB = new ConexionBD();
                    SqlCommand comando = new SqlCommand("MODIFICAR_JUEGO");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOMBRE", txtNombreJuego.Text);
                    comando.Parameters.AddWithValue("@FECHALANZAMIENTO", dtpJuegoLanzamiento.Value.Month + "-" + dtpJuegoLanzamiento.Value.Day + "-" + dtpJuegoLanzamiento.Value.Year); //"2007/12/1"
                    comando.Parameters.AddWithValue("@NOMBREDESARROLLADOR", cmbDesarrolladorJuego.Text);
                    comando.Parameters.AddWithValue("@NOMBRECLASIFICACION", cmbClasificacionJuego.Text);
                    comando.Parameters.AddWithValue("@NOMBREDISTRIBUIDOR", cmbDistribuidores.Text);
                    comando.Parameters.AddWithValue("@PRECIO", txtPrecio.Text);
                    comando.Parameters.AddWithValue("@IDJUEGO",lblMOSTARJUEGO.Text);
                    comando.Parameters.AddWithValue("@CANTIDAD", int.Parse(txtCantidad.Text));
                    DB.AbrirConexion();
                    DB.EjecutarComando(comando);
                    string cadena = " SELECT NOMBRE  FROM JUEGOS";
                    cmbJuegoSeleccion.DisplayMember = "NOMBREJUEGOS";
                    cmbJuegoSeleccion.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));

                    DB.CerrarConexion();

                    MessageBox.Show("JUEGO ACTUALIZADO");
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                    return;
                }
                this.LimpiarDatos();
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro De Eliminar a El JUEGO: " + cmbJuegoSeleccion.Text + "?" + "\n no se podra recuperar", "Elimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //no quiso

                return;
            }
            else
            {
                //si quiso
                try
                {
                    //ConexionBD.Servidor = SERVIDOR; //ANGEL - PC\SQLEXPRESS
                    //ConexionBD.BaseDatos = "FAKE_STEAM";
                    //ConexionBD.Usuario = this.USAURIO;
                    //ConexionBD.Contraseña = this.CONTRA;
                    //ConexionBD DB = new ConexionBD();
                    SqlCommand comando = new SqlCommand("ELIMINAR_JUEGO");
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOMBRE", cmbJuegoSeleccion.Text);
                    DB.AbrirConexion();
                    DB.EjecutarComando(comando);
                    DB.CerrarConexion();

                    MessageBox.Show("SE ELIMINO USUARIO :" + cmbJuegoSeleccion.Text);
                    this.LimpiarDatos();

                    DB.AbrirConexion();
                    DB.EjecutarComando(comando);
                    string cadena = " SELECT NOMBRE  FROM JUEGOS";
                    cmbJuegoSeleccion.DisplayMember = "NOMBREJUEGOS";
                    cmbJuegoSeleccion.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));

                    DB.CerrarConexion();
                    //tmrEliminar.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
