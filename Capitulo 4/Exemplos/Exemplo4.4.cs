/*
 * Exemplo 4.4
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
            Console.WriteLine("{0:D}", 5);
            Console.WriteLine("{0:D10}", 5);
            Console.WriteLine("{0,5:D}", 5);
            Console.WriteLine("{0:F}", 5.5530);
            Console.WriteLine("{0:F3}", 5.5530);
            Console.WriteLine("{0:F0}", 5.5530);
            Console.WriteLine("{0,5:D}", 5);
            Console.WriteLine("{0,5:D}", 55);
            Console.WriteLine("{0,5:D}", 555);
            Console.WriteLine("{0,5:D}{1, -5:D}", 5, 5);
            Console.WriteLine("{0,5:D}{1, -5:D}", 55, 55);
            Console.WriteLine("{0,5:D}{1, -5:D}", 555, 555);
        }
    }
}
