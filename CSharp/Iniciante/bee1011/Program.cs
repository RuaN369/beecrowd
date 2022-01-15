using System;
using System.Globalization;

namespace bee1011
{
    class Program
    {
        static void Main(string[] args)
        {

            double res, pi = 3.14159;
            int R = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            res = 4 / 3.0 * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = {0}", res.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
