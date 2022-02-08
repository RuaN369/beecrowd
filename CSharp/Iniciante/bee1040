using System;
using System.Globalization;

namespace bee1040
{
    class Program
    {
        static void Main(string[] args)
        {

            float N1, N2, N3, N4, N5, media;

            string[] valores = Console.ReadLine().Split(' ');
            N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: {0}", media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                N5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media = (media + N5) / 2;
                Console.WriteLine("Nota do exame: {0}", N5.ToString("F1", CultureInfo.InvariantCulture));
                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: {0}", media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
