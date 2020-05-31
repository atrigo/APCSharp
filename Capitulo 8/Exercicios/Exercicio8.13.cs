/*
 * Exercicio 8.13
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {
        static void apresentaVetor(int[] v)
        {
            foreach (int n in v)
                Console.Write(" {0}", n);
            Console.WriteLine();
        }

        static int[] intercalaVectores(int[] A, int[] B)
        {
            int k = 0; 
            int[] R = new int[A.Length*2];
            for (int i = 0; i < A.Length; i++)
            {
                R[k++] = A[i];
                R[k++] = B[i];
            }
            return R;
        }

        static void Main(string[] args)
        {
            int[] A= { 2, 1, 8, 7, 6};
            int[] B= { 5, 4, 3, 0, 9};
            Console.Write("Vetor A: ");
            apresentaVetor(A);
            Console.Write("Vetor B: ");
            apresentaVetor(B);
            Console.Write("Vetores intercalados: ");
            apresentaVetor(intercalaVectores(A,B));
        }
    }
}
