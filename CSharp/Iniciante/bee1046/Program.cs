using System;

namespace bee1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrI, hrF, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            hrI = int.Parse(vet[0]);
            hrF = int.Parse(vet[1]);

            if (hrI > hrF)
            {
                duracao = 24 - hrI + hrF;
            }else if (hrI - hrF == 0)
            {
                duracao = 24;
            }
            else
            {
                duracao = hrF - hrI;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            Console.ReadKey();

        }
    }
}
