namespace VolumenCaja;

class Program
{

    static float Insertar(string b)
    {
        float a;
        string cadena;
        Console.WriteLine($"Inserte {b} de la caja:");
        cadena = Console.ReadLine();
        while (float.TryParse(cadena, out a) == false)
        {
            Console.WriteLine($"Inserte {b} de la caja:");
            cadena = Console.ReadLine();
        }
        return a;
    }
    static void Main(string[] args)
    {


        float Ancho, Profundidad, Alto, Volumen;

        Ancho = Insertar("el ancho");
        Profundidad =Insertar("la profundidad");
        Alto = Insertar("el alto");

        Volumen = Ancho*Alto*Profundidad;
        Console.WriteLine($"El volumen es {Volumen}m³");
    }
}