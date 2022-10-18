using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEncabezado_Tickets
    {
        public int Codigo_ti { get; set; }
        public string Fecha_trabajo { get; set; }
        public int Codigo_cl { get; set; }
        public string Nrodoc_cl { get; set; }
        public string Nombre_cl { get; set; }
        public int Codigo_me { get; set; }
        public decimal Total_ti { get; set; }
        public int Codigo_tu { get; set; }
        public int Codigo_tdp { get; set; }
        public string Serie_tdp { get; set; }
        public string Corr_tdp { get; set; }
        public int Codigo_us { get; set; }
    }
}
