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
    public class NSubFamilias
    {
        public static DataTable Listado(int codiogo_fa, byte estado, string texto )
        {
            DSubFamilias oDatos = new DSubFamilias();
            return oDatos.Listado(codiogo_fa, estado, texto);
        }
        public static string Guardar(int opt_guarda, ESubFamilias oEntidad)
        {
            DSubFamilias oDatos = new DSubFamilias();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DSubFamilias oDatos = new DSubFamilias();
            return oDatos.Eliminar(codigo);
        }
    }
}
