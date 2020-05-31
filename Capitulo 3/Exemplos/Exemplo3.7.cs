/*
 * Exemplo 3.7
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
            int a = 10;
            Console.WriteLine("{0}", a = 5);
            Console.WriteLine("{0}", a += 3);
            Console.WriteLine("{0}", a -= 2);
            Console.WriteLine("{0}", a *= 5);
            Console.WriteLine("{0}", a /= 2);
            Console.WriteLine("{0}", a %= 4);
        }
    }
}
