/*
 * Exercicio 7.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static double Maior(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Introduza o 1º valor: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza o 2º valor: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O maior valor é: {0}", Maior(x, y));
        }
    }
}
