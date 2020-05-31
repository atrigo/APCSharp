/*
 * Exercicio 7.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static void Sauda(string nome)
        {
            Console.WriteLine("Olá {0} ", nome);
        }
        static void Main(string[] args)
        {
            Console.Write("Qual o nome? ");
            string nome = Console.ReadLine();
            Sauda(nome);
        }
    }
}
