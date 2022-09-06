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
    public class NFamilias
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DFamilias oDatos = new DFamilias();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EFamilias oEntidad)
        {
            DFamilias oDatos = new DFamilias();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DFamilias oDatos = new DFamilias();
            return oDatos.Eliminar(codigo);
        }
    }
}
