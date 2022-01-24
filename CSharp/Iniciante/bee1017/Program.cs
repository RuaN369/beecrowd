using System;
using System.Globalization;

namespace bee1017
{
    class Program
    {
        static void Main(string[] args)
        {


            double A, B, X;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            X = A * B / 12;

            Console.WriteLine(X.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
