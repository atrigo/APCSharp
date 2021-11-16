/*
 * Exercício 8.27
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
        
	static void SelectionSort(int[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                int min_pos = i;
                for (int j = i + 1; j < v.Length; j++)
                    if (v[j] < v[min_pos])
                        min_pos = j;
     
                int temp = v[min_pos];
                v[min_pos] = v[i];
                v[i] = temp;
            }
        }

        public static void Main()
        {
      	    int[] v = {3,4,6,2,3,9,1,2,9,1};
            Console.WriteLine("Vetor original: ");
	    ApresentaVetor(v);
	    SelectionSort(v);
            Console.WriteLine("Vetor ordenado: ");
    	    ApresentaVetor(v);
        }
    }
}
