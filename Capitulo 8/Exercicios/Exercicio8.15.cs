/*
 * Exercicio 8.15
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
            int j, k = 0;
            int[] R = new int[A.Length + B.Length];// O vetor resultante terá no máximo o número de elementos correspondente à soma do nº de elementos dos dois vetores
            foreach(int i in A) // Este ciclo percorre o vetor A
            {
                j = 0;
                while (i != R[j] && j < k)
                    j++;
                if (j == k) // Se j==k quer dizer que o ciclo chegou ao fim sem encontrar o valor e como tal deve ser acrescentado ao vetor R
                    R[k++] = i;
            }
            foreach(int i in B)// Este ciclo percorre o vetor B
            {
                j = 0;
                while (i != R[j] && j < k)
                    j++;
                if (j == k) // Se j==k quer dizer que o ciclo chegou ao fim sem encontrar o valor e como tal deve ser acrescentado ao vetor R
                    R[k++] = i;
            }
            Array.Resize(ref R, k); // Redimensiona o vetor resultante para o nº efectivo de elementos da reunião : K
            return R;
        }

        static void Main(string[] args)
        {
            int[] A= { 2, 1, 8, 9, 0, 6, 7, 3, 8, 1};
            int[] B= { 5, 4, 8, 1, 9, 6, 4};
            Console.Write("Vetor A: ");
            apresentaVetor(A);
            Console.Write("Vetor B: ");
            apresentaVetor(B);
            Console.Write("União dos vetores : ");
            apresentaVetor(intersectaVectores(A,B));
        }
    }
}
