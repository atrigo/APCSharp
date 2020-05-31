/*
 * Exemplo 8.6
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
            int[] v = { 23, 24, 25, 26, 27, 13, 14, 15, 16, 17 };
            foreach (int num in v)
            {
                Console.WriteLine(num);
            }
        }
    }
}
