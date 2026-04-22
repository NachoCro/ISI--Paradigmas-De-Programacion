using System.Diagnostics.Tracing;
using System;
namespace ordenados
{
    class Program
    {
        static int consulta(string b)
        {
            int a;
            Console.Write(b);
            string c = Console.ReadLine();
            while (!int.TryParse(c, out a))
            {
                System.Console.Write(b);
                c = Console.ReadLine();
            }
            return a;
        }

        static string listaOrdenada(int N)
        {
            int ant, act;

            ant = consulta("Ingrese un numero:");

            for (int i = 1; i < N ; i++)
            {
                act = consulta($"Ingrese el numero :");

                if (ant > act)
                {
                    ant = act;
                }
                else
                {
                    return "Los numeros no estan ordenados de mayor a menor";
                }
            }
            return "Los numeros estan ordenados de mayor a menor";
        }
        static void Main()
        {
            int N;
            N = consulta("Ingrese la cantidad de numeros mayor o igual que 2: ");

            while (N < 2)
            {
                N = consulta("Ingrese la cantidad de numeros mayor o igual que 2: ");
            }
            
            System.Console.WriteLine(listaOrdenada(N));
        }
    }
}