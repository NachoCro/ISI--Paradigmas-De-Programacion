namespace clase6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res, a, b;

            a = 1;
            b = 2;

            res = buscarP(a,b);

            Console.WriteLine($"El mayor es: {res}");



            Console.ReadKey();
        }

        static void buscar(int a, int b, out int c, out int d)
        {
           if (a < b)
            {
                c = b;
                d = a;
            }
            c = a;
            d = b;
        }
        static bool buscarP(int a, int b, out int c, out int d)
        {
            bool todoOk = false;
            if (a != b) {
                todoOk = true;
                if (a < b)
                {
                    c = b;
                    d = a;
                }
                c = a;
                d = b;
            }
            return todoOk;
        }

        
    }
}
