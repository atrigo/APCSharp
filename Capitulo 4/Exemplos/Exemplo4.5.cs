/*
 * Exemplo 4.5
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
            string nome = Console.ReadLine();
            Console.WriteLine("Bem vindo {0}", nome);
        }
    }
}
