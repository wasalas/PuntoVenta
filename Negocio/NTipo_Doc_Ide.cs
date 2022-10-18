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
    public class NTipo_Doc_Ide
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DTipo_Doc_Ide oDatos = new DTipo_Doc_Ide();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, ETipo_Doc_Ide oEntidad)
        {
            DTipo_Doc_Ide oDatos = new DTipo_Doc_Ide();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DTipo_Doc_Ide oDatos = new DTipo_Doc_Ide();
            return oDatos.Eliminar(codigo);
        }
    }
}
