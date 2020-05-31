/*
 * Exercicio 7.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static void linhaAster(int N)
        {
            for(int i=0;i<N;i++)
                Console.Write("*");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int N,M;
            Console.Write("Quantos asteriscos? ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantas linhas? ");
            M = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<M;i++)
                linhaAster(N);
        }
    }
}
