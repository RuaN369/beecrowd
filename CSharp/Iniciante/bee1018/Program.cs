using System;
using System.Globalization;

namespace bee1018
{
    class Program
    {
        static void Main(string[] args)
        {

            int val, resto, cem, cinquenta, vinte, dez, cinco, dois, hum;

            val = int.Parse(Console.ReadLine());

            cem = val / 100;
            resto = val % 100;

            cinquenta = resto / 50;
            resto = resto % 50;

            vinte = resto / 20;
            resto = resto % 20;

            dez = resto / 10;
            resto = resto % 10;

            cinco = resto / 5;
            resto = resto % 5;

            dois = resto / 2;
            resto = resto % 2;

            hum = resto / 1;
            resto = resto % 1;

            Console.WriteLine(val);
            Console.WriteLine($"{cem} nota(s) de R$ 100,00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{dez} nota(s) de R$ 10,00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{dois} nota(s) de R$ 2,00");
            Console.WriteLine($"{hum} nota(s) de R$ 1,00");

            Console.ReadKey();

        }
    }
}
