/*
 * Exercício 8.28
 * Livro: Aprenda a programar com C#
 * Autores: António Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/
using System;

namespace Cap8
{
    class Program
    {
        static void ApresentaVetor(int[] v){
          for (int i = 0; i < v.Length; i++)
                    Console.Write("{0} " , v[i]);
          Console.WriteLine();
        }

        static void BubbleSort(int[] v)
        {
            for (int i = 0; i < v.Length -1 ; i++)
                for (int j = 0; j < v.Length - i - 1; j++)
                    if (v[j] > v[j + 1])
                    {
                        int temp = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = temp;
                    }
        }

        public static void Main()
        {
            int[] v = {3,4,6,2,3,9,1,2,9,1};
            Console.WriteLine("Vetor original: ");
            ApresentaVetor(v);
            BubbleSort(v);
            Console.WriteLine("Vetor ordenado: ");
            ApresentaVetor(v);
        }
    }
}
