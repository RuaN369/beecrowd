using System;
using System.Globalization;

namespace bee1019
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, hr, mi, s, resto;

            N = int.Parse(Console.ReadLine());

            hr = N / 3600;
            resto = N % 3600;

            mi = resto / 60;
            s = resto % 60;

            Console.WriteLine($"{hr}:{mi}:{s}");

            Console.ReadKey();

        }
    }
}
