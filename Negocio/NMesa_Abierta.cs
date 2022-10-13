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
    public class NMesa_Abierta
    {        
        public static DataTable Listado_SubFamilias_RP(int codigo_pv)
        {
            DMesa_Abierta oDatos = new DMesa_Abierta();
            return oDatos.Listado_SubFamilias_RP(codigo_pv);
        }
        public static DataTable Listado_Productos_SubFamilia_RP(int codigo_pv, int codigo_sf)
        {
            DMesa_Abierta oDatos = new DMesa_Abierta();
            return oDatos.Listado_Productos_SubFamilia_RP(codigo_pv, codigo_sf);
        }

    }
}
