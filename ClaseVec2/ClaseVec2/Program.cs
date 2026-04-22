namespace ClaseVec2
{
    internal class Program
    {
        static void Mostrar(int[] v)
        {
            int total = 0;
            for (int i = 0; i < v.Length; i++)
            {
                total += v[i];
            }
            Console.WriteLine($"el total es {total}");
        }
        static void Mayor(int[] v)
        {
            int may = v[0];

            for (int i = 0;i < v.Length; i++)
            {
                if (may < v[i])
                {
                    may = v[i];
                }
            }
            Console.WriteLine($"El mayor es {may}");
        }
        static void Main(string[] args)
        {
            int[] importes = {1200, 500, 3400, 213, 700, 630};

            Mostrar(importes, importes.Length);
            Mayor(importes, importes.Length);
        }
    }
}
