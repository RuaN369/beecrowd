using System;
using System.Globalization;

namespace bee1012
{
    class Program
    {
        static void Main(string[] args)
        {

            double tri, cir, tra, qua, ret;

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            tri = A * C / 2.0;
            cir = 3.14159 * Math.Pow(C, 2);
            tra = (A + B) * C / 2;
            qua = B * B;
            ret = A * B;

            Console.WriteLine("TRIANGULO: " + tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "   + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "  + tra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "  + qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
