/*
 * Exercício 8.23
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
                    Console.Write("{0,3}", v[i,j]);
                Console.WriteLine();
            }
        }

        static int[,] transposta(int[,] a)
        {
           int[,] r = new int[a.GetLength(1),a.GetLength(0)];// A matriz transposta terá o nº de linhas trocado com o nº de  colunas
           for (int i=0; i<r.GetLength(0);i++) // Linha
                for (int j=0; j<r.GetLength(1);j++) // Coluna
                    r[i,j]+=a[j,i];
            return r;
        }

        static void Main(string[] args)
        {
            int[,] A = new int[3, 2] { { 2, 1 }, { 7, 2}, { 8, 9 }};
            Console.WriteLine("*** Matriz A ***");
            apresentaMatriz(A);
            Console.WriteLine("*** Matriz Transposta ***");
            apresentaMatriz(transposta(A));
        }
    }
}
