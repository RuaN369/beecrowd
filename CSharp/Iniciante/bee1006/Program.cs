using System;
using System.Globalization;

namespace bee1006
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B , C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
