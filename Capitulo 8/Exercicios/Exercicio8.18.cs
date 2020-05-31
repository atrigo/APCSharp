/*
 * Exercício 8.18
 * Livro: Aprenda a programar com C#
 * Autores: António Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/
using System;

namespace Cap8
{
    class Program
    {
        static void apresentaMatriz(int[,] v)
        {
            for (int i=0; i<v.GetLength(0);i++) // Linha
            {
                for (int j=0; j<v.GetLength(1);j++) // Coluna
                    Console.Write(" {0}", v[i,j]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] V = new int[4,3];
            for(int i=0;i<V.GetLength(0);i++)
                for (int j=0; j<V.GetLength(1);j++)
                {
                    Console.Write("Introduza um número inteiro: ");
                    V[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            apresentaMatriz(V);
        }
    }
}
