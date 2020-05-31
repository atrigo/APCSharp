/*
 * Exemplo 3.5
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
            int a = 2, b = 5;
            float c = 2, d = 5;
            Console.WriteLine("Divisao por inteiros: {0}/{1}={2}", b, a, b / a);
            Console.WriteLine("Divisao por reais: {0}/{1}={2}", d, c, d / c);
            Console.WriteLine("Divisao por reais utilizando o operador de casting: {0}/{1}={2}", b, a, (float)b / a);

        }
    }
}
