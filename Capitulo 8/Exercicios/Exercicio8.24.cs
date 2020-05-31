/*
 * Exercício 8.24
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
                    Console.Write("{0,5}", v[i,j]);
                Console.WriteLine();
            }
        }

        static int[,] multiplicaMatrizes(int[,] a, int[,] b)
        {
           int[,] r = new int[a.GetLength(0),b.GetLength(1)];// A matriz produto terá o nº de linhas de A e o nº de colunas de B
           for (int i=0; i<r.GetLength(0);i++) // Linha
                for (int j=0; j<r.GetLength(1);j++) // Coluna
                    for (int k=0; k<a.GetLength(1);k++)
                        r[i,j]+=a[i,k]*b[k,j];
            return r;
        }

        static void Main(string[] args)
        {
            int[,] A = new int[3, 2] { { 2, 1 }, { 7, 2}, { 8, 9 }};
            int[,] B = new int[2, 3] { { 12, 21, 28 }, { 48, 91, 53 } };
            Console.WriteLine("*** Matriz A ***");
            apresentaMatriz(A);
            Console.WriteLine("*** Matriz B ***");
            apresentaMatriz(B);
            Console.WriteLine("*** Matriz PRODUTO ***");
            if(A.GetLength(1)==B.GetLength(0))// Para que seja possível efectuar a multiplicação é necessário que o nº de colunas de A seja igual ao nº de linhas de B
                apresentaMatriz(multiplicaMatrizes(A, B));
        }
    }
}
