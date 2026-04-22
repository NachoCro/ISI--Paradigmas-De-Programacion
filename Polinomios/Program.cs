namespace Name
{
    internal class Program
    {
        /*
        Se cuenta con un conjunto de polinomios de segundo grado, de cada polinomio se ingresarán los
coeficientes A, B y C, y se deberá determinar si posee raíces reales o imaginarias. Al finalizar, presentar un
resumen que detalle la cantidad de polinomios con raíces reales y la cantidad con raíces imaginarias.
        */
        static float Insertar(string b)
        {
            float a;
            string c;
            System.Console.WriteLine(b);
            c = Console.ReadLine();
            while (!float.TryParse(c, out a))
            {
                System.Console.WriteLine(b);
                c = Console.ReadLine();
            }
            return a;
        }
        static bool RaizReal(float A, float B, float C)
        {
            bool r = false;
            if ((B * B - 4 * A * C) < 0)
            {
                r = true;
            }
            return r;
        }

        static void CantidadRaices(float a, float b, float c, ref int r, ref int i)
        {
            
                if (RaizReal(a, b, c))
                {
                    r++;
                }
                else
                {
                    i++;
                }
        }
        static void Main()
        {
            int Reales = 0, imaginarias = 0;
            float a, b, c;
            string fin;
            
            do{

                a = Insertar("Inserte el primer coeficiente: ");
                b = Insertar("Inserte el segundo coeficiente: ");
                c = Insertar("Inserte el tercer coeficiente: ");

                CantidadRaices(a,b,c,ref Reales, ref imaginarias);

                System.Console.WriteLine("desea finalizar? y - si / n - no");
                fin = Console.ReadLine();
            }while (fin.ToLower() != "y");

            System.Console.WriteLine($"Raices Reales: {Reales} \nRaices imaginarias: {imaginarias}");
        }
    }
}