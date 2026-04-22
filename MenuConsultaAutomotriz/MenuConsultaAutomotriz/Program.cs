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
using System.Diagnostics;
using System.Reflection.Metadata;

namespace MenuConsultaAutomotriz
{
    internal class Program
    {
        static string Consultar(string a)
        {
            System.Console.WriteLine(a);
            string opcion = Console.ReadLine();
            return opcion;
        }

        static float consultarColor()
        {
            string opcion = Consultar("Que color desea: \n > Negro - $250 \n > Blanco - $180 \n > Rojo - $200 \n > Azul - $190");
            switch (opcion.Trim().ToLower())
            {
                case "negro": return 250;
                case "blanco": return 180;
                case "rojo": return 200;
                case "azul": return 190;
                default:
                    {
                        Exception err = new Exception("No hay mas colores.");
                        throw err;
                    }
            }
        }

        /*Vinilo $ 150
        Cuero $ 750
        Tela $ 200

        */
        static float consultarTapizado()
        {
            string opcion = Consultar("Que tapizado desea: \n > Vinilo - $150 \n" +
                " > Cuero - $750 \n > Tela - $200");
            switch (opcion.Trim().ToLower())
            {
                case "vinilo": return 150;
                case "cuero": return 750; 
                case "tela": return 200; 
                default:
                    {
                        Exception err = new Exception("No hay mas tapizados.");
                        throw err;
                    }
            }
        }

        static void Menu()
        {
            float PrecioC = 0, PrecioT = 0;
            bool valido;
            string opcion = Consultar("Que desea seleccionar: \n > Color \n > Tapizado \n > Salir");
            while (opcion.Trim().ToLower() != "salir")
            {
                
                valido = false;
                switch (opcion.Trim().ToLower())
                {
                    case "color":
                        {
                            while (!valido)
                            {
                                try
                                {
                                    PrecioC = consultarColor();
                                    valido = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Error: " + e.Message);
                                }
                            }
                            break;
                        }
                    case "tapizado":
                        {
                            while (!valido)
                            {

                                try
                                {
                                    PrecioT = consultarTapizado();
                                    valido = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Error: " + e.Message);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("No existe esa opcion");
                            Console.ReadKey();
                            break;
                        }
                }
                Console.Clear();
                opcion = Consultar($"Que desea seleccionar: \n > Color \n > Tapizado \n > Salir \n > Precio : {PrecioC + PrecioT}");
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
