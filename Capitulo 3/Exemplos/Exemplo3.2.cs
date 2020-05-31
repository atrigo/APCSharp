/*
 * Exemplo 3.2
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
            string nome;
            int idade;
            Console.Write("Insira o seu nome : ");
            nome = Console.ReadLine();
            Console.Write("Insira a sua idade : ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bem vindo {0}. Tem {1} ano (s).", nome, idade);
        }
    }
}
