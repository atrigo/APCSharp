/*
 * Memorizar 8.5
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 3, 7, 4, 9, 2, 6, 7, 8, 9, 2 };
            for (int i = 0; i < v.Length; i++)
            {
                int iMenor = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[iMenor])
                    {
                        iMenor = j;
                    }
                }
                int aux = v[i];
                v[i] = v[iMenor];
                v[iMenor] = aux;
            }
            Console.Write("Resultado: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0} ", v[i]);
            }
            Console.WriteLine();
        }
    }
}
