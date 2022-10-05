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
    public class NUnidades_Medida
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DUnidades_Medida oDatos = new DUnidades_Medida();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EUnidades_Medida oEntidad)
        {
            DUnidades_Medida oDatos = new DUnidades_Medida();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DUnidades_Medida oDatos = new DUnidades_Medida();
            return oDatos.Eliminar(codigo);
        }
    }
}
