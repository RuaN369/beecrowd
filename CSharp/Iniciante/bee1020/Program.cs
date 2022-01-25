using System;

namespace bee1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, anos, mes, dias, resto;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;

            mes = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadKey();

        }
    }
}
