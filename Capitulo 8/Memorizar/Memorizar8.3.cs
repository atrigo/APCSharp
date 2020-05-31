/*
 * Memorizar 8.3
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
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                soma += v[i];
            }
            Console.WriteLine("Resultado: {0:F}", (float)soma / v.Length);
        }
    }
}
