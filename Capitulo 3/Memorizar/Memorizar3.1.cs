/*
 * Memorizar 3.1
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
            int a, b, c;
            Console.WriteLine("Insira um numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira outro numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a:{0}, b:{1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a:{0}, b:{1}", a, b);
        }
    }
}
