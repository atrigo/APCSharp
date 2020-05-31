/*
 * Exemplo 7.8
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static float Soma(float x, float y)
        {
            return x * y;
        }
        static int Soma(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            float a = 2.5F, b = 3F;
            int c = 4, d = 5;
            Console.WriteLine("{0:F2}+{1:F2}={2:F2}", a, b, Soma(a, b));
            Console.WriteLine("{0}+{1}={2}", c, d, Soma(c, d));
        }
    }
}
