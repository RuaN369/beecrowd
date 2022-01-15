using System;
using System.Globalization;

namespace bee1008
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B;
            double C, res;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            res = B * C;

            Console.WriteLine("NUMBER = {0}\nSALARY = U$ {1}", A, res.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
