/*
 * Exemplo 8.7
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
            int[] v = new int[] { 3, 7, 4, 9, 2, 6, 7, 8, 9, 2 };
            Console.WriteLine("Indice: {0}", Array.IndexOf(v, 7));
        }
    }
}
