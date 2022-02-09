using System;
using System.Globalization;

namespace bee1041
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] val = Console.ReadLine().Split(' ');
            double x = double.Parse(val[0], CultureInfo.InvariantCulture);
            double y = double.Parse(val[1], CultureInfo.InvariantCulture);

            // Q1 = X+ e Y+
            // Q2 = X- e Y+

            // Q3 = X- e Y-
            // Q4 = X+ e Y-

            // Origem = 0 e 0

            // Eixo X = 0
            // Eixo Y = 0

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.ReadKey();

        }
    }
}
