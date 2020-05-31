/*
 * Exercicio 8.9
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
        static bool iguais(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            else
                for (int i = 0; i < a.Length; i++) 
                    if(a[i] != b[i])
                        return false;
            return true;
        }
        static void Main(string[] args)
        {
            int[] O = { 2, 6, 8, 7, 3, 9, 1, 5}, R= { 2, 6, 8, 7, 3, 9, 1, 5};// Experimente alterar os valores
            apresentaVetor(O);
            apresentaVetor(R);
            if(iguais(O,R))
                Console.WriteLine("Os vetores são iguais");
            else
                Console.WriteLine("Os vetores não são iguais");
        }
    }
}
