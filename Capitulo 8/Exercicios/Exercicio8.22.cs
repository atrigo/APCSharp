/*
 * Exercício 8.22
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
                    Console.Write("{0,4}", v[i,j]);
                Console.WriteLine();
            }
        }

        static int[,] multEscalar(int e, int[,] a)
        {
           int[,] r = new int[a.GetLength(0),a.GetLength(1)];
           for (int i=0; i<a.GetLength(0);i++) // Linha
                for (int j=0; j<a.GetLength(1);j++) // Coluna
                    r[i,j]=a[i,j]*5;
            return r;
        }

        static void Main(string[] args)
        {
            int[,] A = new int[4, 3] { { 2, 1, 8 }, { 7, 2, 6 }, { 8, 9, 5 }, { 8, 2, 9 } };
            Console.WriteLine("*** Matriz A ***");
            apresentaMatriz(A);
            Console.WriteLine("*** Matriz Resultante da multiplicação de A pelo escalar 5 ***");
            apresentaMatriz(multEscalar(5, A));
        }
    }
}
