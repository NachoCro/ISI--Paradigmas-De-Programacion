namespace TrianguloRectangulo
{
    class Program
    {
        static float Insertar(string b)
        {
            float a;
            string c;
            Console.WriteLine($"Ingres el {b} angulo de triangulo");
            c = Console.ReadLine();
            while (float.TryParse(c, out a) == false)
            {
                Console.WriteLine($"Ingrese el {b} angulo de triangulo");
                c = Console.ReadLine();
            }

            return a;
        }

        static void Validacion(float a, float b, float c)
        {
            if (a + b + c != 180
            && (a == 180 || c == 180 || b == 180))
            {
                Console.WriteLine("NO ES UN TRIANGULO");
            }
            else if (a == 90 || b == 90 || c == 90)
            {
                Console.WriteLine("Es un triangulo rectangulo");
            }
            else
            {
                Console.WriteLine("No es un triangulo rectangulo");
            }
        }

        static void Main()
        {
            float Angulo1, Angulo2, Angulo3;


            Angulo1 = Insertar("primer");
            Angulo2 = Insertar("segundo");
            Angulo3 = Insertar("tercer");

            Validacion(Angulo1, Angulo2, Angulo3); // C:
        }
    }
}