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
    public class DEncabezado_Tickets
    {
        public DataTable Guardar(EEncabezado_Tickets oEntidad, DataTable dtDetalle)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spGuardar_Tickets", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fecha_trabajo", SqlDbType.VarChar).Value = oEntidad.Fecha_trabajo;
                Comando.Parameters.Add("@codigo_cl", SqlDbType.Int).Value = oEntidad.Codigo_cl;
                Comando.Parameters.Add("@nrodoc_cl", SqlDbType.VarChar).Value = oEntidad.Nrodoc_cl;
                Comando.Parameters.Add("@nombre_cl", SqlDbType.VarChar).Value = oEntidad.Nombre_cl;
                Comando.Parameters.Add("@codigo_me", SqlDbType.Int).Value = oEntidad.Codigo_me;
                Comando.Parameters.Add("@total_ti", SqlDbType.Decimal).Value = oEntidad.Total_ti;
                Comando.Parameters.Add("@codigo_tu", SqlDbType.Int).Value = oEntidad.Codigo_tu;
                Comando.Parameters.Add("@codigo_us", SqlDbType.Int).Value = oEntidad.Codigo_us;
                Comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dtDetalle;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Tabla;
        }
        public DataTable Mostrar_Tickets_Mesa(int codigo_me)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spMostrar_Tickets_Mesa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_me", SqlDbType.Int).Value = codigo_me;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Tabla;
        }
    }
}
