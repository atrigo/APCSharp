/*
 * Exercicio 8.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {
        static void indMax(int[] v)
        {
            int max = v[0];// Começamos por assumir que o maior está no índice 0
            foreach (int n in v) //No final deste ciclo o maior valor estrá na variável max
                if (n > max)
                    max = n;
            Console.Write("O valor máximo ocorre no(s) índice(s):");
            for (int i = 1; i < v.Length; i++)// Com este ciclo serão apresentados todos os índices onde o máximo ocorre
                if (v[i] == max)
                    Console.Write(" {0}",i);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] V = { 2, 6, 8, 9, 3, 9, 6, 4, 9, 6 };
            indMax(V);
        }
    }
}
