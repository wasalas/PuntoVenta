using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class DImagen_Predeterminada
    {
        public byte[] Mostrar()
        {
            byte[] imagen = new byte[0];
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spMostrar_Imagen_Predeterminada", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                if (Tabla.Rows.Count != 0)
                    imagen = (byte[])Tabla.Rows[0][0];
                return imagen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public byte[] Imagen_Estado_Mesa(int estado)
        {
            byte[] imagen = new byte[0];
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spMostrar_Imagen_Estado_Mesa", SqlCon);
                Comando.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                if (Tabla.Rows.Count != 0)
                    imagen = (byte[])Tabla.Rows[0][0];
                return imagen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

    }

}
