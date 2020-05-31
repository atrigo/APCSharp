/*
 * Exercicio 8.14
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

        static int[] intersectaVectores(int[] A, int[] B)
        {
            int k = 0,n;
            if (A.Length < B.Length) // O vetor resultante terá no máximo o número de elementos do menor vetor
                n = A.Length;
            else
                n = B.Length;
            int[] R = new int[n];
            foreach(int i in A)
                foreach(int j in B)
                    if(i==j)
                        R[k++] = i;
            Array.Resize(ref R, k); // Redimensiona o vetor resultante para o nº efectivo de elementos da intersecção : K
            return R;
        }

        static void Main(string[] args)
        {
            int[] A= { 2, 1, 8, 9, 6, 7, 3, 0};// Vetor sem elementos repetidos
            int[] B= { 5, 4, 8, 1, 9};// Vetor sem elementos repetidos
            Console.Write("Vetor A: ");
            apresentaVetor(A);
            Console.Write("Vetor B: ");
            apresentaVetor(B);
            Console.Write("Intersecção dos vetores : ");
            apresentaVetor(intersectaVectores(A,B));
        }
    }
}
