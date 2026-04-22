namespace Rendimiento
{
    /*
     Se leen pares de valores. El primero es la cantidad de kilómetros recorridos y el segundo el consumo de
combustible. Para cada par calcular el rendimiento (km/litro).
Indicar si se introducirá un nuevo par de datos o se dará por finalizado el proceso respondiendo con ‘C’, a
la pregunta: “¿Continúa?”.
*/
    class Program
    {
        static float Insertar(string a)
        {
            string b;
            float c;
            Console.WriteLine(a);
            b = Console.ReadLine();
            while (!float.TryParse(b, out c)) {
                Console.WriteLine(a);
                b = Console.ReadLine();
            }
            return c;
        }
        static void Rendimiento(out float R)
        {
            string tecla;
            float km, l;
            do
            {
            km = Insertar("Ingrese una cantidad recorrida en km: ");
            l = Insertar("Inserte el consumo de litros: ");
            R = km/l;
            System.Console.WriteLine($"Rendimiento: {R}");
            Console.WriteLine("Continua? \n c - cerrar \n otra tecla - continuar");
            tecla = Console.ReadLine();
                
            }while (tecla.ToLower() != "c");
        }
        static void Main(string[] args)
        {
            float rend;
            Rendimiento(out rend);
        }
    }
}