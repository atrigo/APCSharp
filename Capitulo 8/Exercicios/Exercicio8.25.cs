/*
 * Exercício 8.25
 * Livro: Aprenda a programar com C#
 * Autores: António Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/
using System;

namespace Cap8
{
    class Program
    {
        static void apresentaMatriz(string[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);
        }

        static void Main(string[] args)
        {
            string[] nomes = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduza o {0}º nome:", i + 1);
                nomes[i] = Console.ReadLine();
            }
            apresentaMatriz(nomes);
        }
    }
}
