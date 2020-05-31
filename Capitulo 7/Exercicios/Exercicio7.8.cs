/*
 * Exercicio 7.8
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static double hipotenusa(double a, double b)
        {
            return Math.Sqrt(a*a+b*b);
        }

        static void Main(string[] args)
        {
            double c1, c2;
            Console.Write("Introduza o valor do 1º cateto: ");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza o valor do 2º cateto: ");
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hipotenusa {0}", hipotenusa(c1,c2));
        }
    }
}
