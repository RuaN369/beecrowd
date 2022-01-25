using System;
using System.Globalization;

namespace bee1036
{
    class Program
    {
        static void Main(string[] args)
        {

            double delta;

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = (B * B) - (4 * A * C);
            double raiz = Math.Sqrt(delta);
            var a1 = ((-(B)) + raiz) / (2 * A);
            var a2 = ((-(B)) - raiz) / (2 * A);

            if (a1 <= 0)
            {

                Console.WriteLine("R1 = " + a1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + a2.ToString("F5", CultureInfo.InvariantCulture));
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Impossivel calcular");
                Console.ReadKey();
            }

            Console.ReadKey();

        }
    }
}
