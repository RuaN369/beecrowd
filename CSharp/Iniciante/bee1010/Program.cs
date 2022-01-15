using System;
using System.Globalization;

namespace bee1010
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int nu1 = int.Parse(vet1[1]);
            double val1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int nu2 = int.Parse(vet2[1]);
            double val2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valPagar;

            valPagar = (val1 * nu1) + (val2 * nu2);

            Console.WriteLine("VALOR A PAGAR: R$ {0}", valPagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
