/*
 * Exemplo 5.11
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
            int valor1;
            Console.WriteLine("Insira um numero: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", valor1 % 2 == 0 ? "par":"impar");
        }
    }
}
