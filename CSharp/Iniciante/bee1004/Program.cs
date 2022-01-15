using System;

namespace bee1004
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B , C;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            C = A * B;

            Console.WriteLine($"PROD = {C}");
            Console.ReadKey();
        }
    }
}
