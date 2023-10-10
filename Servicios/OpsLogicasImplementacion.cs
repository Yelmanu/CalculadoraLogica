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
        public void igualdad()
        {
            string cadena1 = pedirCadena1();
            string cadena2 = pedirCadena1();

            if( cadena1 == cadena2)
            {
                Console.WriteLine("El resultado de la igualdad es: true");
            }
            else
            {
                Console.WriteLine("El resultado de la igualdad es: false");
            }
            

        }

        /// <summary>
        /// Método para determinar si las cadenas de texto introducidas por el usuario 
        /// son iguales o son desiguales
        /// </summary>
        /// <returns></returns>
        public void desigualdad()
        {
            string cadena1 = pedirCadena1();
            string cadena2 = pedirCadena1();

            if ( cadena1 != cadena2) 
            {
                Console.WriteLine("El resultado de la desigualdad es: true");
            }
            else
            {
                Console.WriteLine("El resultado de la desigualdad es: false");
            }
            
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
    }
}
