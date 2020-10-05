/*
 * Exemplo 10.3
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
            int numero1 = 3000;
            int numero2 = 0;
            try
            {
                Console.WriteLine(numero1 / numero2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisao {0} por zero.", numero1);
            }
        }
    }
}
