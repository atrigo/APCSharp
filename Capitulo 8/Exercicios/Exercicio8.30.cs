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
        
        static void Trocar(int[] v, int i, int j)
        {
            int temp = v[i];
            v[i] = v[j];
            v[j] = temp;
        }
  
        static int Particao(int[] v, int linf, int lsup)
        {
            int pivot = v[lsup]; 
            int i = (linf - 1); 
  
            for(int j = linf; j <= lsup - 1; j++)
            {
                if (v[j] < pivot) 
                {
                    i++; 
                    Trocar(v, i, j);
                }
            }
            Trocar(v, i + 1, lsup);
            return (i + 1);
        }
  
        static void QuickSort(int[] v, int linf, int lsup)
        {
            if (linf < lsup) 
            {
                int pi = Particao(v, linf, lsup);
                QuickSort(v, linf, pi - 1);
                QuickSort(v, pi + 1, lsup);
            }
        }

        public static void Main()
        {
            int[] v = {3,4,6,2,3,9,1,2,9,1};
            Console.WriteLine("Vetor original: ");
			      ApresentaVetor(v);
			      QuickSort(v,0,v.Length-1);
            Console.WriteLine("Vetor ordenado: ");
			      ApresentaVetor(v);
        }
    }
}
