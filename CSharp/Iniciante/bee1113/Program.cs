using System;

namespace bee1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            while (X != Y)
            {
                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }

            Console.ReadKey();

        }
    }
}
