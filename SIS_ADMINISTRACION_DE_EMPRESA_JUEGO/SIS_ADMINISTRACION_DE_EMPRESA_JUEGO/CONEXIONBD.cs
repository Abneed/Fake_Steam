using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    class CONEXIONBD
    {
        private string cadena_Conexion = string.Format("Server={0};Database={1};User Id={2};" + "Password={3}", _Servidor, _BaseDatos, _Usuario, _Contraseña);
        private static string _Usuario, _Contraseña, _Servidor, _BaseDatos;
        private SqlConnection cn;

        public static string Base_Datos
        {
            get
            {
                return _BaseDatos;
            }

            set
            {
                _BaseDatos = value;
            }
        }

        public static string Contraseña
        {
            get
            {
                return _Contraseña;
            }

            set
            {
                _Contraseña = value;
            }
        }

        public static string Servidor
        {
            get
            {
                return _Servidor;
            }

            set
            {
                _Servidor = value;
            }
        }

        public static string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public void Conectar()
        {
            cn = new SqlConnection(cadena_Conexion);
        }

        public void AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        public void CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public void EjecutarComando(SqlCommand cmd) //Para ejecutar Insert, Delete, Update o procedimientos sin select
        {
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
        }

        public DataTable EjecutarConsulta(SqlCommand cmd) //Para ejecutar SELECT, este metodo devuelve un objeto DataTable con el resultado de la consulta
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable DatosConsulta = new DataTable();
            da.Fill(DatosConsulta);
            return DatosConsulta;
        }

        public CONEXIONBD()
        {
            Conectar();
        }
    }
}
