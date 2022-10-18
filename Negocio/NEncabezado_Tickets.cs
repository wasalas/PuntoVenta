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
    public class NEncabezado_Tickets
    {
        public static DataTable Guardar(EEncabezado_Tickets oEntidad, DataTable dtDetalle)
        {
            DEncabezado_Tickets oDatos = new DEncabezado_Tickets();
            return oDatos.Guardar(oEntidad, dtDetalle);
        }
        public static DataTable Mostrar_Tickets_Mesa(int codigo_me)
        {
            DEncabezado_Tickets oDatos = new DEncabezado_Tickets();
            return oDatos.Mostrar_Tickets_Mesa(codigo_me);
        }
    }
}
