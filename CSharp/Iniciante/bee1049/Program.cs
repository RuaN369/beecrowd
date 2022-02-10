using System;

namespace bee1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();
            string val3 = Console.ReadLine();

            if (val1 == "vertebrado")
            {

                if (val2 == "ave")
                {
                    if (val3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (val3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }

                else if (val2 == "mamifero")
                {
                    if (val3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (val3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else if (val1 == "invertebrado")

            {
                if (val2 == "inseto")
                {
                    if (val3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (val3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }

                else if (val2 == "anelideo")
                {
                    if (val3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (val3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
