/*
 * Exemplo 6.12
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine("Iteracao {0}: {1:F2}", i, (float)1 / (i - 5));
            }
        }
    }
}
