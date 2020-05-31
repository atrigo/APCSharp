/*
 * Exemplo 3.6
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
            int a = 10, b;
            Console.WriteLine("a: {0}", a++); //sufixo
            a = 10;
            Console.WriteLine("a: {0}", ++a); //prefixo
            a = 10;
            b = a++; //sufixo
            Console.WriteLine("Antes:{0} Depois:{1}", b, a);
            a = 10;
            b = ++a; //prefixo
            Console.WriteLine("Antes:{0} Depois:{1}", b, a);
        }
    }
}
