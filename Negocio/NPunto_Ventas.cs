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
    public class NPunto_Ventas
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DPunto_Venta oDatos = new DPunto_Venta();
            return oDatos.Listado(estado, texto);
        }
        public static DataTable OK(int opcion, int codigo_pr)
        {
            DPunto_Venta oDatos = new DPunto_Venta();
            return oDatos.OK(opcion, codigo_pr);
        }
        public static string Guardar(int opt_guarda, EPunto_Venta oEntidad)
        {
            DPunto_Venta oDatos = new DPunto_Venta();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DPunto_Venta oDatos = new DPunto_Venta();
            return oDatos.Eliminar(codigo);
        }
    }
}
