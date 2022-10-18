using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EClientes
    {
        public int Codigo_cl { get; set; }
        public int Codigo_tdi { get; set; }
        public string Nrodoc_cl { get; set; }
        public string Nombre_cl { get; set; }
        public string Telefono_cl { get; set; }
        public string Celular_cl { get; set; }
        public string Correo_cl { get; set; }
        public string Direccion_cl { get; set; }
        public byte Estado { get; set; }
    }
}
