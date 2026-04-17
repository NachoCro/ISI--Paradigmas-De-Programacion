namespace TrianguloRectangulo
{
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

        static bool esTriangulo(float a, float b, float c)
        {
            if (a <= (b + c) || b <= (a + c) || c <= (b + a))
            {
                return true;
            }
            return false;
        }

        static void TipoTriangulo(float a, float b, float c)
        {
            if (a == b && a == c)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else if (a == b || a == c || c == b)
            {
                Console.WriteLine("Es un triangulo isoseles");
            }
            else
            {
                Console.WriteLine("es un triangulo escaleno");
            }
        }
        static void Main()
        {
            float lado1, lado2, lado3;


            Insertar("Inserte el primer lado: ", lado1);
            Insertar("Inserte el segundo lado: ", lado2);
            Insertar("Inserte el tercer lado: ", lado3);


            if (esTriangulo(lado1, lado2, lado3))
            {
                TipoTriangulo(lado1, lado2, lado3);
            }
            else
            {
                Console.WriteLine("no es un triangulo");
            }

        }
    }
}