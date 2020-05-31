
/*
 * Exercicio 4.9
 * Enunciado: Escreva um programa que peça o nome ao utilizador e mostre a mensagem ``Bom dia <nome\_do\_utilizador>.''.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Introduza o seu nome: "); 
            nome = Console.ReadLine();
            Console.WriteLine("Bom dia {0}", nome);
        }
    }
}
