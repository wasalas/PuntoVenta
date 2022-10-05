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
    public class NMesas
    {
        public static DataTable Listado(int codiogo_pv, byte estado, string texto )
        {
            DMesas oDatos = new DMesas();
            return oDatos.Listado(codiogo_pv, estado, texto);
        }
        public static string Guardar(int opt_guarda, EMesas oEntidad)
        {
            DMesas oDatos = new DMesas();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DMesas oDatos = new DMesas();
            return oDatos.Eliminar(codigo);
        }
    }
}
