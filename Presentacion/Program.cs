using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmMDIPrincipal());
            Application.Run(new frmDashBoard());

            //Application.Run(new Procesos.frmRegistro_Pedidos());
            //Application.Run(new Procesos.frmMesa_Abierta());

            //Application.Run(new frmClientes());

        }
    }
}
