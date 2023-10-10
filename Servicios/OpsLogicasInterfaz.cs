using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la opercaion de igualdad a realizar por la aplicación
    /// 101023 - MDN
    /// </summary>
    internal interface OpsLogicasInterfaz
    {
        /// <summary>
        /// Realiza la comprobacion de la igualdad de cadenas de texto introducidas
        /// 101023 - MDN
        /// </summary>
        /// <returns></returns>
        public void igualdad();

        /// <summary>
        /// Realiza la comprobación de la desigualdad de cadenas de texto introducidas
        /// </summary>
        /// <returns></returns>
        public void desigualdad();
    }
}
