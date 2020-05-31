/*
 * Exemplo 4.6
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
            Console.WriteLine("Insira uma letra e carregue Enter");
            Console.WriteLine(Console.Read()); //Mostra o codigo ASCII da letra
            Console.WriteLine(Console.Read()); //Mostra o codigo ASCII do Enter
        }
    }
}
