/*
 * Exemplo 9.4
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
            string strA = "A";
            string strB = "B";
            Console.WriteLine(strA.CompareTo(strB)); //-1
            Console.WriteLine(strB.CompareTo(strA)); // 1
            Console.WriteLine(strB.CompareTo(strB)); // 0
        }
    }
}
