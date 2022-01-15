using System;
using System.Globalization;

namespace bee1014
{
    class Program
    {
        static void Main(string[] args)
        {


            double Y, res;
            int X = int.Parse(Console.ReadLine());
            Y  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            res = X / Y;

            Console.WriteLine("{0} km/l", res.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
