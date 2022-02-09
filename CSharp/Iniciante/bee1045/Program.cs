using System;
using System.Globalization;

namespace bee1044
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, x, y, z;

            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (x > y && x > z)
            {
                A = x;

                if (y > z)
                {
                    B = y;
                    C = z;
                }
                else
                {
                    B = z;
                    C = y;
                }
            }
            else if (y > z)
            {
                A = y;

                if (x > z)
                {
                    B = x;
                    C = z;
                }
                else
                {
                    B = z;
                    C = x;
                }
            }
            else
            {
                A = z;

                if (x > y)
                {
                    B = x;
                    C = y;
                }
                else
                {
                    B = y;
                    C = x;
                }
            }

            Console.Clear();

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            Console.ReadKey();

        }
    }
}
