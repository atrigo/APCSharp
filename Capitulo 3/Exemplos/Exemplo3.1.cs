/*
 * Exemplo 3.1
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
            short a = 5;
            int b;
            float c = 8.5f;
            b = a;
            // No conversao acima nao ha perda de informacao
            Console.WriteLine("Inteiro: " + b);
            Console.WriteLine("Real: " + c);
            b = (int)c;
            // Na conversao acima perde -se a informacao do valor decimal
            Console.WriteLine("Inteiro: " + b);
        }
    }
}
