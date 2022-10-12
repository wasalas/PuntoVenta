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
    public class NTurnos
    {
        public static DataTable Listado(byte estado, string texto )
        {
            DTurnos oDatos = new DTurnos();
            return oDatos.Listado(estado, texto);
        }
        public static string Guardar(int opt_guarda, ETurnos oEntidad)
        {
            DTurnos oDatos = new DTurnos();
            return oDatos.Guardar(opt_guarda, oEntidad);
        }
        public static string Eliminar(int codigo)
        {
            DTurnos oDatos = new DTurnos();
            return oDatos.Eliminar(codigo);
        }
    }
}
