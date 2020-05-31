/*
 * Exercicio 6.18
 * Enunciado:   Escreva um programa que mostre todos os primos entre 1 e N sendo N um número inteiro fornecido pelo utilizador. 
 *              O programa deverá mostrar também o número de divisões que ele executou para encontrar os números primos.
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
            int N, n, i,cont=0;
            Console.Write("Introduza o valor de N:");
            N = Convert.ToInt32(Console.ReadLine());
            for (n = 2; n <= N; n++)
            {
                for (i = 2; i <= Math.Sqrt(n); i++)
                {
                    cont++;
                    if (n % i == 0)
                        break;
                }
                if(i > Math.Sqrt(n))
                    Console.Write(" {0}",n);
            }
            Console.WriteLine("\nForam efectuadas {0} divisões", cont);
        }
    }
}
