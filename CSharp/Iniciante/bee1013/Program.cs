using System;

namespace bee1013
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, maior;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maior = (A + B + Math.Abs(A - B)) / 2;
            maior = (maior + C + Math.Abs(maior - C)) / 2;

            Console.WriteLine($"{maior} eh o maior");
            Console.ReadKey();
        }
    }
}
