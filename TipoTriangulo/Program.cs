namespace TrianguloRectangulo
{
    class Program
    {
        static float Insertar(string b)
        {
            float a;
            string c;
            System.Console.WriteLine($"Ingres el {b} lado de triangulo");
            c = Console.ReadLine();
            while (float.TryParse(c, out a) == false)
            {
                System.Console.WriteLine($"Ingrese el {b} lado de triangulo");
                c = Console.ReadLine();
            }

            return a;
        }

        static bool esTriangulo(float a,float b,float c){
            if(a <= (b+c) || b <= (a+c) || c <= (b+a)){
                return true;
            }
            return false;
        }

        static void TipoTriangulo(float a,float b,float c){
            if(a == b && a == c){
                System.Console.WriteLine("Es un triangulo equilatero");
            }else if(a == b || a == c || c == b){
                System.Console.WriteLine("Es un triangulo isoseles");
            }else{
                System.Console.WriteLine("es un triangulo escaleno");
            }
        }
        static void Main()
        {
            float lado1, lado2, lado3;


            lado1 = Insertar("primer");
            lado2 = Insertar("segundo");
            lado3 = Insertar("tercer");

            if(esTriangulo(lado1, lado2, lado3)){
                TipoTriangulo(lado1, lado2, lado3);
            }else{
                System.Console.WriteLine("no es un triangulo");
            }
            
        }
    }
}