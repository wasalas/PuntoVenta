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
    public class NCierres_Turnos
    {
        public static DataTable Estado_Turno_PV(int codigo_pv )
        {
            DCierres_Turnos oDatos = new DCierres_Turnos();
            return oDatos.Estado_Turno_PV(codigo_pv);
        }
    }
}
