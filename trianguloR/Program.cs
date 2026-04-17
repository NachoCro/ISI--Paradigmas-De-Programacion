namespace TrianguloRectangulo
{
    class Program
    {
        static void Insertar(string b, out float a)
        {
            string c;
            Console.WriteLine({b});
            c = Console.ReadLine();
            while (float.TryParse(c, out a) == false)
            {
                Console.WriteLine({b});
                c = Console.ReadLine();
            }
        }

        static void Validacion(float a, float b, float c)
        {
            if (a + b + c != 180 && (a == 180 || c == 180 || b == 180))
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

            Insertar("Ingrese el primer angulo", Angulo1);
            Insertar("Ingrese el primer angulo", Angulo2);
            Insertar("Ingrese el primer angulo", Angulo3);

            Validacion(Angulo1, Angulo2, Angulo3); // C:
        }
    }
}