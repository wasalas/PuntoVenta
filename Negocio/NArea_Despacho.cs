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
    public class NArea_Despacho
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DArea_Despacho oDatos = new DArea_Despacho();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EArea_Despacho oEntidad)
        {
            DArea_Despacho oDatos = new DArea_Despacho();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DArea_Despacho oDatos = new DArea_Despacho();
            return oDatos.Eliminar(codigo);
        }
    }
}
