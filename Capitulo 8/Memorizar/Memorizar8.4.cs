/*
 * Memorizar 8.4
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
            int menor = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < menor)
                    menor = v[i];
            }
            Console.WriteLine("Resultado: {0}", menor);
        }
    }
}
