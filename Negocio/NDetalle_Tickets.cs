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
        public static DataTable Listado_Detalle_Tickets(string impresora, int codigo_ti)
        {
            DDetalle_Tickets oDatos = new DDetalle_Tickets();
            return oDatos.Listado_Detalle_Tickets(impresora, codigo_ti);
        }        
    }
}
