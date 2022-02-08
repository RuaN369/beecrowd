using System;
using System.Globalization;

namespace bee1038
{
    class Program
    {
        static void Main(string[] args)
        {

            double codigo, quantidade, res;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                res = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                res = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                res = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                res = quantidade * 2.0;
            }
            else
            {
                res = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ {0}", res.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
