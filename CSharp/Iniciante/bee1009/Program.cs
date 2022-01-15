using System;
using System.Globalization;

namespace bee1009
{
    class Program
    {
        static void Main(string[] args)
        {

            double salFix, totalVendas, res;
            
            string nome = Console.ReadLine();
            salFix = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            res = totalVendas * 0.15 + salFix;

            Console.WriteLine("TOTAL = R$ {0}", res.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
