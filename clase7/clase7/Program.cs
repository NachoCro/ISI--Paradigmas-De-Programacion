namespace clase7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = 1;
            b = 2;

            interCambiar(ref a, ref b);

            Console.WriteLine($"a vale: {a}");
            Console.WriteLine($"b vale: {b}");
        }

        static void interCambiar(ref int x, ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;

        }

    }
}
