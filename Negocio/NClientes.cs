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
    public class NClientes
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DClientes oDatos = new DClientes();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, EClientes oEntidad)
        {
            DClientes oDatos = new DClientes();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DClientes oDatos = new DClientes();
            return oDatos.Eliminar(codigo);
        }
    }
}
