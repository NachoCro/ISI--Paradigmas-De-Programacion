using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace VectorInfo;

class Program
{

    static void IngresarVector(int[] v)
    {
        string c;
        for (int i = 0; i < v.Length; i++)
        {
            System.Console.WriteLine("Ingrese un numero:");
            c = Console.ReadLine();
            while (!int.TryParse(c, out v[i]))
            {
                System.Console.WriteLine("Ingrese un numero:");
                c = Console.ReadLine();
            }
        }
    }

    static void Mostrar(int[] v)
    {
        for (int i = 0; i < v.Length; i++)
        {
            System.Console.WriteLine($"{i + 1} : {v[i]}");
        }
    }

    static void SuperanPromedio(int[] v, int[] s, out int c)
    {
        int prom;
        c = 0;
        Promedio(v, out prom);
        for (int i = 0; i < v.Length; i++)
        {
            if (prom < v[i])
            {
                s[c] = v[i];
                c++;
            }
        }
    }

    static void Promedio(int[] v, out int prom)
    {
        int total = 0;
        for (int i = 0; i < v.Length; i++)
        {
            total = total + v[i];
        }

        prom = total / v.Length;
    }

    static void Main(string[] args)
    {
        int[] nums = new int[5];

        int cuantos;

        int[] superan = new int[5];

        IngresarVector(nums);

        SuperanPromedio(nums, superan, out cuantos);

        System.Console.WriteLine("cantidad que superan el promedio: " + cuantos);

        Mostrar(superan);
    }
}
