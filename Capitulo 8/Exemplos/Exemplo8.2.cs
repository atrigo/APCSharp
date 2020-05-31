/*
 * Exemplo 8.2
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
            Console.Write("Quantos elementos deseja para o vetor:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Insira um numero para a posicao {0}:", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Valor na posicao {0}: {1}", i, v[i]);
            }
        }
    }
}
