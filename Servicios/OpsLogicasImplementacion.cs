using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    /// <summary>
    /// Clase que se encarga del funcionamiento de la calculadora lógica
    /// 101023 - MDN
    /// </summary>
    internal class OpsLogicasImplementacion : OpsLogicasInterfaz
    {
        /// <summary>
        /// Método para determinar si las cadenas de texto introducidas por el usuario 
        /// son iguales o son desiguales
        /// 101023 - MDN
        /// </summary>
        /// <returns></returns>
        public bool igualdad()
        {
            string cadena1 = pedirCadena1();
            string cadena2 = pedirCadena2();

            if( cadena1 ==cadena2)
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// Método para determinar si las cadenas de texto introducidas por el usuario 
        /// son iguales o son desiguales
        /// </summary>
        /// <returns></returns>
        public bool desigualdad()
        {

        }

        /// <summary>
        /// Métodos para pedir las cadenas de texto que se van a comparar en la igualdad
        /// 101023 - MDNs
        /// </summary>
        /// <returns></returns>
        private string pedirCadena1()
        {
            string cadena1;

            Console.WriteLine("Introduce la primera expresión: ");
            cadena1 = Console.ReadLine();

            return cadena1;

        }

        private string pedirCadena2()
        {
            string cadena2;

            Console.WriteLine("Introduce la primera expresión: ");
            cadena2 = Console.ReadLine();

            return cadena2;
        }
    }
}
