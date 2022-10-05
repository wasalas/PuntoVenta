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
    public class NImagen_Productos
    {
        public static byte[] Mostrar(int codigo_pr)
        {
            DImagen_Productos oDatos = new DImagen_Productos();
            return oDatos.Mostrar(codigo_pr);
        }        
    }
}
