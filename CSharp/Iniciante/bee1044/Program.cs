using System;
using System.Globalization;

namespace bee1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int b = int.Parse(vet[1], CultureInfo.InvariantCulture);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadKey();

        }
    }
}
