/*
 * Memorizar 6.3
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
            int numero, menor;
            Console.WriteLine("Insira um numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            menor = numero;
            while (numero != 0)
            {
                Console.WriteLine("Insira um numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (menor > numero && numero != 0)
                    menor = numero;
            }
            Console.WriteLine("O menor numero e {0}.", menor);
        }
    }
}
