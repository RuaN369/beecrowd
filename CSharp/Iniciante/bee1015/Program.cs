using System;
using System.Globalization;

namespace bee1015
{
    class Program
    {
        static void Main(string[] args)
        {

            double distancia;

            string[] p1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            string[] p2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);


            distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
