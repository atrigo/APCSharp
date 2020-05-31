/*
 * Exercicio 6.21
 * Enunciado: Escreva um programa que determine o mínimo múltiplo comum (MMC) de dois números.
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
            int a, b,c,d, r;
            Console.Write("Introduza o primeiro número:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o segundo número:");
            b = Convert.ToInt32(Console.ReadLine());
            c = a; d = b;
            while ((r = a % b) != 0) // Calcula o máximo divisor comum
            {
                a = b;
                b = r;
            }
            Console.WriteLine("O mínimo múltiplo comum de {0} e {1} é {2}", c, d,c*d/b);
        }
    }
}
