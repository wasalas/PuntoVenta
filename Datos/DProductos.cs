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
    public class DProductos
    {
        public DataTable Listado(byte estado, string texto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = estado;
                Comando.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
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
        public DataTable Listado_Productos_SubFamilia_PuntoVenta(int codigo_pv)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spListado_Productos_SubFamilia_PuntoVenta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo_pv", SqlDbType.Int).Value = codigo_pv;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
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
        public string Guardar(int opcion, EProductos oEntidad, DataTable dtDatos)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spGuardar_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@opt_guarda", SqlDbType.Int).Value = opcion;
                Comando.Parameters.Add("@codigo_pr", SqlDbType.Int).Value = oEntidad.Codigo_pr;
                Comando.Parameters.Add("@descripcion_pr", SqlDbType.VarChar).Value = oEntidad.Descripcion_pr;
                Comando.Parameters.Add("@codigo_ma", SqlDbType.Int).Value = oEntidad.Codigo_ma;
                Comando.Parameters.Add("@codigo_um", SqlDbType.Int).Value = oEntidad.Codigo_um;
                Comando.Parameters.Add("@codigo_fa", SqlDbType.Int).Value = oEntidad.Codigo_fa;
                Comando.Parameters.Add("@codigo_sf", SqlDbType.Int).Value = oEntidad.Codigo_sf;
                Comando.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value = oEntidad.Precio_unitario;
                Comando.Parameters.Add("@codigo_ad", SqlDbType.Int).Value = oEntidad.Codigo_ad;
                Comando.Parameters.Add("@observaciones", SqlDbType.Text).Value = oEntidad.Observaciones; 
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = oEntidad.Estado;
                Comando.Parameters.Add("@imagen", SqlDbType.Image).Value = oEntidad.Imagen;
                Comando.Parameters.Add("@Ty_pv", SqlDbType.Structured).Value = dtDatos;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo guardar la información";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }
        public string Eliminar(int codigo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spEliminar_Productos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar.";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

    }
}
