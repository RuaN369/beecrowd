using System;
using System.Globalization;

namespace bee1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double novoSalario, ganhos;
            int percentual;

            if (salario <= 400.00)
            {
                percentual = 15;
                novoSalario = salario * 0.15 + salario;
                ganhos = novoSalario - salario;

            }
            else if (salario <= 800.00)
            {
                percentual = 12;
                novoSalario = salario * 0.12 + salario;
                ganhos = novoSalario - salario;

            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
                novoSalario = salario * 0.10 + salario;
                ganhos = novoSalario - salario;

            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
                novoSalario = salario * 0.07 + salario;
                ganhos = novoSalario - salario;

            }
            else
            {
                percentual = 4;
                novoSalario = salario * 0.04 + salario;
                ganhos = novoSalario - salario;

            }
            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}\nReajuste ganho: {ganhos.ToString("F2", CultureInfo.InvariantCulture)}\nEm percentual: {percentual} %");
            Console.ReadKey();

        }
    }
}
