/*
 * Exercicio 7.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static int Soma(int a, int b)
        {
            return a+b;
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Introduza o 1º valor: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o 2º valor: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Soma: {0}", Soma(x, y));
        }
    }
}
