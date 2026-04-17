namespace EstaturaMedia;

class Program
{

    static void Insertar(string b, out float a)
    {
        string c;
        Console.WriteLine({ b});
        c = Console.ReadLine();
        while (float.TryParse(c, out a) == false)
        {
            Console.WriteLine({ b});
            c = Console.ReadLine();
        }
    }

    static void superaEstatura(string a, float b)
    {
        if ((a == "m" || a == "masculino") && b > 1.72)
        {
            Console.WriteLine("Sos alto");
        }
        if ((a == "m" || a == "masculino") && b < 1.72)
        {
            Console.WriteLine("Sos bajo");
        }
        if ((a == "f" || a == "femenino") && b > 1.65)
        {
            Console.WriteLine("Sos alta");
        }
        if ((a == "f" || a == "femenino") && b > 1.65)
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

        Insertar("Inserte su estatura: ", Estatura);

        superaEstatura(genero, Estatura);

    }
}