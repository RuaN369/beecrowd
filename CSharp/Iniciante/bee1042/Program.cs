using System;

namespace bee1042
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, maior, meio, menor;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A > B && A > C)
            {
                maior = A;

                if (B > C)
                {
                    meio = B;
                    menor = C;
                }
                else
                {
                    meio = C;
                    menor = B;
                }
            }
            else if (B > A && B > C)
            {
                maior = B;

                if (A > C)
                {
                    meio = A;
                    menor = C;
                }
                else
                {
                    meio = C;
                    menor = A;
                }
            }
            else
            {
                maior = C;

                if(A > B)
                {
                    meio = A;
                    menor = B;
                }
                else
                {
                    meio = B;
                    menor = A;
                }
            }

            Console.Clear();

            Console.WriteLine($"{menor}\n{meio}\n{maior}\n");
            Console.WriteLine($"{A}\n{B}\n{C}");

            Console.ReadKey();

        }
    }
}
