using System;
using System.Globalization;

namespace bee1037
{
    class Program
    {
        static void Main(string[] args)
        {

            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (val < 0 || val > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (val <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (val <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (val <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            Console.ReadKey();

        }
    }
}
