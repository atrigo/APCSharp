/*
 * Exercicio 8.10
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {
        static void apresentaVetor(char[] C, int[] N)
        {
            for(int i=0; i<C.Length; i++)
            {
                for(int j=0; j<N[i]; j++)
                    Console.Write(C[i]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            char[] A = { 'A', 'Z', 'D', 'H', 'P', 'B'};
            int[] B= { 2, 6, 8, 7, 9, 5};
            apresentaVetor(A,B);
        }
    }
}
