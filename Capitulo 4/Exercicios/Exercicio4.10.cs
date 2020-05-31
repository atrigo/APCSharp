
/*
 * Exercicio 4.10
 * Enunciado:   Escreva um programa que peça o nome e o apelido ao utilizador e 
 *              imprima o apelido seguido de uma vírgula e do nome.	
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
            string nome,apelido;
            Console.Write("Introduza o seu nome: "); 
            nome = Console.ReadLine();
            Console.Write("Introduza o seu apelido: "); 
            apelido = Console.ReadLine();
            Console.WriteLine("{0}, {1}",apelido, nome);
        }
    }
}
