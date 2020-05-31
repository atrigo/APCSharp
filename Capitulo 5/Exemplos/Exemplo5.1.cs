/*
 * Exemplo 5.1
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
            int peso = 80;
            char genero = 'M';
            Console.WriteLine(peso == 80); //True
            Console.WriteLine(peso >= 80); //True		
            Console.WriteLine(genero == 'F'); //False		
            Console.WriteLine(genero > 'F'); //True
            Console.WriteLine((2 * 3 > 4) != (5 < 2)); //True              
        }
    }
}
