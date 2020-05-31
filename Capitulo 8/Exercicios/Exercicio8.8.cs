/*
 * Exercicio 8.8
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
        static void somaElementosVetor(int[] v, int[] s)
        {
            for (int i = 0; i < v.Length/2; i++) 
                s[i]=v[i]+ v[v.Length-1-i]; 
        }
        static void Main(string[] args)
        {
            int N=8;
            int[] O = { 2, 6, 8, 7, 3, 9, 1, 5}, R=new int[N/2];
            apresentaVetor(O);
            somaElementosVetor(O,R);
            apresentaVetor(R);
        }
    }
}
