/*
 * Exemplo 5.2
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
            Console.WriteLine(4 > 5); //False
            Console.WriteLine(4 < 5 && 6 > 10); //False		
            Console.WriteLine(40 < 50 || 60 > 90); //True		
            Console.WriteLine(!(40 < 50 || 60 > 90)); //False           
        }
    }
}
