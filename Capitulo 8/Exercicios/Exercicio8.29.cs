/*
 * Exercício 8.29
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
        
        static void Merge(int[] v, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
  
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
  
            for (i = 0; i < n1; ++i)
                L[i] = v[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = v[m + 1 + j];
  
            i = 0;
            j = 0;
  
            int k = l;
            while (i < n1 && j < n2) {
                if (L[i] <= R[j]) {
                    v[k] = L[i];
                    i++;
                }
                else {
                    v[k] = R[j];
                    j++;
                }
                k++;
            }
  
            while (i < n1) {
                v[k] = L[i];
                i++;
                k++;
            }
      
            while (j < n2) {
                v[k] = R[j];
                j++;
                k++;
            }
        }
  
  
	static void MergeSort(int[] v, int l, int r)
        {
            if (l < r) {
                int m = l+ (r-l)/2;
                MergeSort(v, l, m);
                MergeSort(v, m + 1, r);
                Merge(v, l, m, r);
            }
        }

        public static void Main()
        {
            int[] v = {3,4,6,2,3,9,1,2,9,1};
            Console.WriteLine("Vetor original: ");
	    ApresentaVetor(v);
	    MergeSort(v,0,v.Length-1);
            Console.WriteLine("Vetor ordenado: ");
	    ApresentaVetor(v);
        }
    }
}
