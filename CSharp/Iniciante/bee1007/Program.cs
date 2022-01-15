using System;

namespace bee1007
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B , C, D, DIF;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIF = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIF}");
            Console.ReadKey();
        }
    }
}
