/*
 * Exercício 8.19
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
            int[,] V = new int[2,5];
            int c = 0, l = 0;
            for(int i=0;i<V.GetLength(0);i++)
                for (int j=0; j<V.GetLength(1);j++)
                {
                    Console.Write("Introduza um número inteiro: ");
                    V[i,j]=Convert.ToInt32(Console.ReadLine());
                    if (V[i, j] > V[l, c])
                    {
                        l = i;
                        c = j;
                    }
                }
            apresentaMatriz(V);
            Console.WriteLine("O maior número da matriz é V[{0},{1}]={2}",l,c,V[l, c]);
        }
    }
}
