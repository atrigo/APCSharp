/*
 * Exemplo 9.5
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
            string frase;
            int i = 0;

            Console.Write("Insira uma frase: ");
            frase = Console.ReadLine();
            while (frase[i] != ' ')
            {
                Console.Write(frase[i]);
                i++;
            }
            Console.WriteLine();
        }
    }
}
