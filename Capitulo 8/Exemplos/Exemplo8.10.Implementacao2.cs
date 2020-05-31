/*
 * Exemplo 8.10 - Implementacao 2
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
            int i, j;
            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (i = 0; i < m.GetLength(0); i++)
            {
                for (j = 0; j < m.GetLength(1); j++)
                    Console.Write("{0} ", m[i, j]);
                Console.WriteLine();
            }
        }
    }
}
