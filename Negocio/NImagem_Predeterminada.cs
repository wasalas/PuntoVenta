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
    public class NImagen_Predeterminada
    {
        public static byte[] Mostrar()
        {
            DImagen_Predeterminada oDatos = new DImagen_Predeterminada();
            return oDatos.Mostrar();
        }        
    }
}
