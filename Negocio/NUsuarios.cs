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
    public class NUsuarios
    {
        public static DataTable Administrador(int codigo_us)
        {
            DUsuarios oDatos = new DUsuarios();
            return oDatos.Adminstrador(codigo_us);
        }
        /*
        public static DataTable Listado(byte estado, string texto )
        {
            DMarcas oDatos = new DMarcas();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EMarcas oEntidad)
        {
            DMarcas oDatos = new DMarcas();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DMarcas oDatos = new DMarcas();
            return oDatos.Eliminar(codigo);
        }
        */
    }
}
