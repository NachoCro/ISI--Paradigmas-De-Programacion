namespace NombreYapellido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Apellido, Nombre, ApellidoyNombre;

            Console.WriteLine("Inserte su apellido: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Inserte su Nombre: ");
            Nombre = Console.ReadLine();

            if (Juntar(Apellido, Nombre, out ApellidoyNombre))
            {
                Console.WriteLine($"Hola {ApellidoyNombre}");
            }
            else
            {
                Console.WriteLine("No esta completado el nombre o apellido");
            }
        }


        static bool Juntar(string A, string N, out string AyN)
        {
            bool funciona = false;
            AyN = string.Empty;
            if (A != string.Empty && N != string.Empty) { 
                funciona = true;
                AyN = $"{A}, {N}";
            }
            return funciona;
        }
    }
}
