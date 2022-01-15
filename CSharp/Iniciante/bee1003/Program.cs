using System;

namespace bee1003
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B , C;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            C = A + B;

            Console.WriteLine($"SOMA = {C}");
            Console.ReadKey();
        }
    }
}
