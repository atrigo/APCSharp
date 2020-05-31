/*
 * Exemplo 2.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Como se chama?");
            // Utilizacao da variavel nomeProprio para
            // ler o nome do utilizador
            string nomeProprio = Console.ReadLine();
            Console.WriteLine("Bem vindo (a) {0} ", nomeProprio);
        }
    }
}

