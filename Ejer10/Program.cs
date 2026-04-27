namespace Ejer10;

class Program
{
    static void Mostrar(int[] v)
    {
        for (int i = 0; i < v.Length; i++)
        {
            System.Console.WriteLine($"{i} : {v[i]}");
        }

    }

    static void Ordenar(int[] v)
    {
        int aux;
        for (int i = 0; i < v.Length - 1; i++)
        {
            for (int j = i + 1; j < v.Length; j++)
            {
                if (v[j] > v[i])
                {
                    aux = v[j];
                    v[j] = v[i];
                    v[i] = aux;
                }
            }
        }
    }

    static void duplicarVariable(ref int a)
    {
        a = a * 2;
    }

    static void Main(string[] args)
    {
        int[] datos = new int[5];

        datos[0] = 2;
        datos[1] = 123;
        datos[2] = 324;
        datos[3] = 32;
        datos[4] = 21;

        Mostrar(datos);
        Ordenar(datos);
        Mostrar(datos);

    }
}
