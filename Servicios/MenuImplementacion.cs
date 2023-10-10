using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú de la aplicación
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.Write("Elija una opción: ");
            Console.WriteLine("\n1.- Cerrar");
            Console.WriteLine("2.- Igualdad");
            Console.WriteLine("3.- Desigualdad");
            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');

            return opcionSeleccionada;
        }


    }
}
