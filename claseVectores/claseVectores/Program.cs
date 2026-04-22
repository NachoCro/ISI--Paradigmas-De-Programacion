namespace claseVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int[] nums = { 1, 2, 3, 4, 5 };
            int may = nums[0], total = 0;

            for (int i = 0; i < 5; i++)
            {
                if (may < nums[i])
                {
                    may = nums[i];
                }
                total += nums[i];
            }
            Console.WriteLine("El mayor numero es: "+may);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"suma total {total}");
            Console.ReadKey();
        }
    }
}