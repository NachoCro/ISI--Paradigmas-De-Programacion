namespace EstaturaMedia;

class Program
{

    static float Insertar(string b)
    {
        float a;
        string c;
        Console.WriteLine("{b}");
        c = Console.ReadLine();
        while (float.TryParse(c, out a) == false)
        {
            Console.WriteLine($"{b}");
            c = Console.ReadLine();
        }

        return a;
    }

    static void superaEstatura(string a, float b)
    {
        if ((a.ToLower == "m" || a.ToLower == "masculino") && b > 1.72)
        {
            Console.WriteLine("Sos alto");
        }
        if ((a.ToLower == "m" || a.ToLower == "masculino") && b < 1.72)
        {
            Console.WriteLine("Sos bajo");
        }
        if ((a.ToLower == "f" || a.ToLower == "femenino") && b > 1.65)
        {
            Console.WriteLine("Sos alta");
        }
        if ((a.ToLower == "f" || a.ToLower == "femenino") && b > 1.65)
        {
            Console.WriteLine("Sos baja");
        }
    }
    static void Main()
    {
        float Estatura;
        string genero;

        Console.WriteLine("Inserte su sexo: \n > M - masculino \n > F - femenino ");
        genero = Console.ReadLine();

        Estatura = Insertar("Ingrese su estatura: ");

        superaEstatura(genero, Estatura);

    }
}