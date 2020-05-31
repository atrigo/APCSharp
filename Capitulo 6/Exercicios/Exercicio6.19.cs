/*
 * Exercicio 6.19
 * Enunciado: Escreva um programa que imprima uma árvore de ``*''.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, n, i;
            Console.Write("Altura da árvore:");
            N = Convert.ToInt32(Console.ReadLine());
            for (n = 0; n < N; n++) // Copa
            {
                for(i=0;i<N-n;i++)
                    Console.Write(" ");
                for(i=0;i<2*n+1;i++)
                    Console.Write("*");
                for(i=0;i<N-n;i++)
                    Console.Write(" ");
                Console.WriteLine();
            }
            for (n = 0; n < N/3; n++) // Tronco (1/3 da copa)
            {
                for (i = 0; i < 2 * N; i++)
                    if(i==N)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                Console.WriteLine();
            }
        }
    }
}
