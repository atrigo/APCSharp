/*
 * Exercicio 9.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Introduza o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O seu nome é {0} ", nome);
        }
    }
}
