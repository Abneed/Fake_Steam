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
   
    public partial class FormReportes : Form
    {
        //public string USUARIO = "";
        //public string CONTRA = "";
        //public string BASE = "";
        private ConexionBD DB = new ConexionBD();
        public FormReportes()
        {
            InitializeComponent();
        }

        private void REPORTES_Load(object sender, EventArgs e)
        {
            try
            {
                //ConexionBD.Servidor = this.BASE; //ANGEL - PC\SQLEXPRESS
                //ConexionBD.BaseDatos = "FAKE_STEAM";
                //ConexionBD.Usuario = this.USUARIO;
                //ConexionBD.Contraseña = this.CONTRA;
                DB.Conectar();
                string cadenausuarios = " select NOMBREPERFIL from USUARIOS";
                cmbUsuarios.DisplayMember = "NOMBREPERFIL";
                cmbUsuarios.DataSource = DB.EjecutarConsulta(new SqlCommand(cadenausuarios));
                DB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            try
            {

            
            //ConexionBD.Servidor = this.BASE; //ANGEL - PC\SQLEXPRESS
            //ConexionBD.BaseDatos = "FAKE_STEAM";
            //ConexionBD.Usuario = this.USUARIO;
            //ConexionBD.Contraseña = this.CONTRA;
            //ConexionBD DB = new ConexionBD();
            DB.Conectar();
            string cadena = "select ven.IDVENTA,VEN.FECHAVENTA,MET.DESCRIPCION,USU.NOMBREPERFIL AS[NOMBRE PERFIL],JUE.NOMBRE AS [NOMBRE DEL JUEGO],VEN.CANTIDAD AS [TOTAL DE COPIAS],VEN.PRECIO AS[PRECIO POR UNIDAD],VEN.CANTIDAD*VEN.PRECIO AS [TOTAL DE LA VENTA] from ventas AS ven join METODOPAGO AS MET ON (MET.IDMETODOPAGO=VEN.IDMETODOPAGO) JOIN USUARIOS AS USU ON(USU.IDUSUARIO=VEN.IDUSUARIO) JOIN VENTAS_JUEGOS AS VENTJUE ON(ven.IDVENTA=VENTJUE.IDVENTA) JOIN JUEGOS AS JUE ON(VENTJUE.IDJUEGO=JUE.IDJUEGO) ORDER BY VEN.FECHAVENTA"; 
            dgvReporte.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
            DB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            timer1.Start();
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {


                //ConexionBD.Servidor = this.BASE; //ANGEL - PC\SQLEXPRESS
                //ConexionBD.BaseDatos = "FAKE_STEAM";
                //ConexionBD.Usuario = this.USUARIO;
                //ConexionBD.Contraseña = this.CONTRA;
                //ConexionBD DB = new ConexionBD();
                DB.Conectar();
                string cadena = "SELECT SUM(CANTIDAD*PRECIO) AS TOTAL FROM VENTAS";
                DataTable NE = new DataTable();

                NE = DB.EjecutarConsulta(new SqlCommand(cadena));
                lblTOTAL.Text = NE.Rows[0]["TOTAL"].ToString();
                DB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //ConexionBD.Servidor = this.BASE; //ANGEL - PC\SQLEXPRESS
                //ConexionBD.BaseDatos = "FAKE_STEAM";
                //ConexionBD.Usuario = this.USUARIO;
                //ConexionBD.Contraseña = this.CONTRA;
                //ConexionBD DB = new ConexionBD();
                DB.Conectar();
                string cadena = "select ven.IDVENTA,VEN.FECHAVENTA,MET.DESCRIPCION,USU.NOMBREPERFIL AS[NOMBRE PERFIL],JUE.NOMBRE AS [NOMBRE DEL JUEGO],VEN.CANTIDAD AS [TOTAL DE COPIAS],VEN.PRECIO AS[PRECIO POR UNIDAD],VEN.CANTIDAD*VEN.PRECIO AS [TOTAL DE LA VENTA] from ventas AS ven join METODOPAGO AS MET ON (MET.IDMETODOPAGO=VEN.IDMETODOPAGO) JOIN USUARIOS AS USU ON(USU.IDUSUARIO=VEN.IDUSUARIO) JOIN VENTAS_JUEGOS AS VENTJUE ON(ven.IDVENTA=VENTJUE.IDVENTA) JOIN JUEGOS AS JUE ON(VENTJUE.IDJUEGO=JUE.IDJUEGO) WHERE USU.NOMBREPERFIL=" + "'" + cmbUsuarios.Text + "'";
                dgvReporte.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                string cadena2 = "SELECT SUM(ven.CANTIDAD*ven.PRECIO) AS TOTAL FROM VENTAS as ven join USUARIOS as usu on(ven.IDUSUARIO = usu.IDUSUARIO) where usu.NOMBREPERFIL =" + " '" + cmbUsuarios.Text + "'";
                DataTable NE = new DataTable();
                NE = DB.EjecutarConsulta(new SqlCommand(cadena2));
                lblTOTAL.Text = NE.Rows[0]["TOTAL"].ToString();
                DB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnPorFecha_Click(object sender, EventArgs e)
        {
            try
            {
                //ConexionBD.Servidor = this.BASE; //ANGEL - PC\SQLEXPRESS
                //ConexionBD.BaseDatos = "FAKE_STEAM";
                //ConexionBD.Usuario = this.USUARIO;
                //ConexionBD.Contraseña = this.CONTRA;
                ConexionBD DB = new ConexionBD();
                DB.Conectar();
                string cadena = "select ven.IDVENTA,VEN.FECHAVENTA,MET.DESCRIPCION,USU.NOMBREPERFIL AS[NOMBRE PERFIL],JUE.NOMBRE AS [NOMBRE DEL JUEGO],VEN.CANTIDAD AS [TOTAL DE COPIAS],VEN.PRECIO AS[PRECIO POR UNIDAD],VEN.CANTIDAD*VEN.PRECIO AS [TOTAL DE LA VENTA] from ventas AS ven join METODOPAGO AS MET ON (MET.IDMETODOPAGO=VEN.IDMETODOPAGO) JOIN USUARIOS AS USU ON(USU.IDUSUARIO=VEN.IDUSUARIO) JOIN VENTAS_JUEGOS AS VENTJUE ON(ven.IDVENTA=VENTJUE.IDVENTA) JOIN JUEGOS AS JUE ON(VENTJUE.IDJUEGO=JUE.IDJUEGO) WHERE ven.FECHAVENTA=" + "'" + dtmFecha.Value.Month + "-" + dtmFecha.Value.Day + "-" + dtmFecha.Value.Year + "'"+ "ORDER BY VEN.FECHAVENTA";
                dgvReporte.DataSource = DB.EjecutarConsulta(new SqlCommand(cadena));
                string cadena2 = "SELECT SUM(ven.CANTIDAD*ven.PRECIO) AS TOTAL FROM VENTAS as ven join USUARIOS as usu on(ven.IDUSUARIO = usu.IDUSUARIO) WHERE ven.FECHAVENTA=" + " '" + dtmFecha.Value.Month + "-" + dtmFecha.Value.Day + "-" + dtmFecha.Value.Year + "'";
                DataTable NE = new DataTable();
                NE = DB.EjecutarConsulta(new SqlCommand(cadena2));
                lblTOTAL.Text = NE.Rows[0]["TOTAL"].ToString();
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
