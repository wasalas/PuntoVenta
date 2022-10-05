using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EProductos
    {
        public int Codigo_pr { get; set; }
        public string Descripcion_pr { get; set; }
        public int Codigo_ma { get; set; }
        public int Codigo_um { get; set; }
        public int Codigo_fa { get; set; }
        public int Codigo_sf { get; set; }
        public decimal Precio_unitario { get; set; }
        public int Codigo_ad { get; set; }
        public string Observaciones { get; set; }
        public byte Estado { get; set; }
        public byte[] Imagen { get; set; }
    }
}
