/*
 * Exemplo 5.8
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
            int lado1, lado2;
            Console.Write("Insira um lado: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira outro lado: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            if (lado1 == lado2)
                Console.WriteLine("A figura geometrica e um quadrado.");
            else
                Console.WriteLine("A figura geometrica e um retangulo.");
        }
    }
}
