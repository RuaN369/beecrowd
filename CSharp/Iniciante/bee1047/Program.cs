using System;

namespace bee1047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrI, hrF, mtI, mtF, res;

            string[] vet = Console.ReadLine().Split(' ');
            hrI = int.Parse(vet[0]);
            mtI = int.Parse(vet[1]);
            hrF = int.Parse(vet[2]);
            mtF = int.Parse(vet[3]);

            hrI = hrI * 60 + mtI;
            hrF = hrF * 60 + mtF;

            if (hrI < hrF)
            {
                res = hrF - hrI;
            }
            else
            {
                res = (24 * 60 - hrI) + hrF;
            }

            int horas = res / 60;
            int minutos = res % 60;

            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
            Console.ReadKey();

        }
    }
}
