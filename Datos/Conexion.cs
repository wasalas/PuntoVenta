using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string BaseDatos;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;
        private Conexion()
        {
            BaseDatos = "dbPuntoVenta";
            Servidor = "WALTHER_11";
            Usuario = "admin";
            Clave = "admin";
            Seguridad = false;

            // Usuario = "sa";
            // Clave = "sa";
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.BaseDatos + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception e)
            {
                Cadena = null;
                throw e;
            }
            return Cadena;
        }
        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
