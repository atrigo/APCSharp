/*
 * Exercicio 8.7
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
                Console.Write(" {0}",n);
            Console.WriteLine();
        }
        static void inverteVetor(int[] v)
        {
            int aux, n=v.Length;
            for (int i = 0; i < n/2; i++) // O limite do ciclo é v.Length/2 porque se fosse v.Length a inversão seria feita e desfeita
            {
                aux = v[i]; // Preserva o valor de v[i] na variável aux antes de trocar o valor de v[i] com v[n-1-i]
                v[i]= v[n-1-i];
                v[n - 1 - i] = aux;
            }
        }
        static void Main(string[] args)
        {
            int[] V = { 2, 6, 8, 7, 3, 9, 1, 5, 8, 0 };
            apresentaVetor(V);
            inverteVetor(V);
            apresentaVetor(V);
        }
    }
}
