using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECierres_Turnos
    {
        public DateTime Fecha_ct { get; set; }
        public int Codigo_pv { get; set; }
        public int Codigo_tu { get; set; }
        public byte Estado_tu { get; set; }
    }
}
