/*
 * Exemplo 6.2
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
            int soma = 0;
            for (int i = 1; i < 51; i++)
            {
                soma = soma + i; //soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
