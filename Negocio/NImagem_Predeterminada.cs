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
        public static byte[] Imagen_Estado_Mesa(int estado)
        {
            DImagen_Predeterminada oDatos = new DImagen_Predeterminada();
            return oDatos.Imagen_Estado_Mesa(estado);
        }
    }
}
