using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class NProductos
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DProductos oDatos = new DProductos();
            return oDatos.Listado(estado, texto);
        }
        public static DataTable Listado_Productos_SubFamilia_PuntoVenta(int codigo_pv)
        {
            DProductos oDatos = new DProductos();
            return oDatos.Listado_Productos_SubFamilia_PuntoVenta(codigo_pv);
        }
        public static string Guardar(int opt_guarda, EProductos oEntidad, DataTable dtDatos)
        {
            DProductos oDatos = new DProductos();
            return oDatos.Guardar(opt_guarda, oEntidad, dtDatos);
        }
        public static string Eliminar(int codigo)
        {
            DProductos oDatos = new DProductos();
            return oDatos.Eliminar(codigo);
        }
    }
}
