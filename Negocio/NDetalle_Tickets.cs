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
    public class NDetalle_Tickets
    {
        public static DataTable Listado_Detalle_Tickets(int codigo_ti)
        {
            DDetalle_Tickets oDatos = new DDetalle_Tickets();
            return oDatos.Listado_Detalle_Tickets(codigo_ti);
        }
        public static DataTable Listado_Detalle_Tickets2(int codigo_ti)
        {
            DDetalle_Tickets oDatos = new DDetalle_Tickets();
            return oDatos.Listado_Detalle_Tickets2(codigo_ti);
        }
        public static DataTable Listado_Detalle_Tickets_PRN(string impresora, int codigo_ti)
        {
            DDetalle_Tickets oDatos = new DDetalle_Tickets();
            return oDatos.Listado_Detalle_Tickets_PRN(impresora, codigo_ti);
        }
    }
}
