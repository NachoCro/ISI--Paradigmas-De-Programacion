/*
 * Una automotriz desea determinar el precio de venta adecuado para una línea nueva donde el cliente
puede seleccionar el color del mismo y su tapizado. Implementar un menú que permita realizar múltiples
consultas. Tener en cuenta la información brindada en las siguientes tablas:

Color Importe
Negro $ 250
Rojo $ 200
Blanco $ 180
Azul $ 190

Tapizado Importe
Vinilo $ 150
Cuero $ 750
Tela $ 200

*/

using System.ComponentModel;

namespace MenuConsultaAutomotriz
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Que desea seleccionar: \n > Color \n > Tapizado \n > Salir");
            string opcion = Console.ReadLine();
            while (opcion != "Salir")
            {
                switch (opcion)
                {
                    case "Color":
                        {
                            Console.WriteLine("Haz elegido un color");
                            break;
                        }
                    case "Tapizado":
                        {
                            Console.WriteLine("Haz elegido un tapizado");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("No existe esa opcion");
                            break; 
                        }
            Console.WriteLine("Que desea seleccionar: \n > Color \n > Tapizado \n > Salir");
            string opcion = Console.ReadLine();
                }
            }
            Console.WriteLine("has salido del programa...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
