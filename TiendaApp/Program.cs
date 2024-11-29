using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaApp.Autenticacion;

namespace TiendaApp
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

            // Descomentar al momento de pasar a producción
            //bool autenticado = false;

            //// Crear una instancia de nuestro Login (crear un objeto)
            //Login login = new Login();

            //// Para mostrar una ventana
            //login.ShowDialog();

            //autenticado = login.autorizado;

            //if (autenticado)
            //{
            //    Application.Run(new Form1());
            //}
            //

            Application.Run(new Form1());
        }
    }
}
