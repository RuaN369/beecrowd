using System;
using System.Globalization;

namespace bee1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Pe, Ar;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < A + C && C < A + B)
            {
                Pe = A + B + C;

                Console.WriteLine("Perimetro = {0}", Pe.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Ar = C * (A + B) / 2;

                Console.WriteLine("Area = {0}", Ar.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
