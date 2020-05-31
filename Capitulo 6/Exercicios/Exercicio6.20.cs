/*
 * Exercicio 6.20
 * Enunciado: Escreva um programa que determine o máximo divisor comum (MDC) de dois números utilizando o algoritmo de Euclides.
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
            int a, b, r;
            Console.Write("Introduza o primeiro número:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o segundo número:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("O máximo divisor comum de {0} e {1} é ", a, b);
            while ((r = a % b) != 0)
            {
                a = b;
                b = r;
            }
            Console.WriteLine(b);
        }
    }
}
