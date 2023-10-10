using CalculadoraLogica.Servicios;

namespace CalculadoraLogica
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Instanciamos las clases que contienen los métodos de la aplicación
            MenuInterfaz menuCalculadora = new MenuImplementacion();
            OpsLogicasInterfaz calculadoraLogica = new OpsLogicasImplementacion();

            //Creamos una variable bool y una variable int para el menu (bool para el control
            //de flujo while e int para capturar la opcion introducida por el usuario)
            bool cerrarMenu = false;
            int opcionIntroducida;

            //Bucle while para controlar cuando se muestra o se cierra el menú

            while (!cerrarMenu)
            {
                opcionIntroducida = menuCalculadora.mostrarMenu();
                Console.WriteLine("[INFO] Has seleccionado la opción {0}", opcionIntroducida);

                switch(opcionIntroducida)
                {
                    case 1:
                        cerrarMenu = true; 
                        break;
                    case 2:
                        calculadoraLogica.igualdad();
                        break;
                    case 3:
                        calculadoraLogica.desigualdad();
                        break;
                    default:
                        Console.WriteLine("[INFO] La opción introducida no existe.");
                        break;
                }
            }
        }
    }
}
