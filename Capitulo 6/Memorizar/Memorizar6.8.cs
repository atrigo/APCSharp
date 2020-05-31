/*
 * Memorizar 6.8
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
            int idade;
            do
            {
                Console.Write("Insira uma idade entre 1 e 120 anos: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade < 1 || idade > 120)
                    Console.WriteLine("Idade incorreta.");
            } while (idade < 1 || idade > 120);
        }
    }
}
