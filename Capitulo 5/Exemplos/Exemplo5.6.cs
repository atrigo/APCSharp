/*
 * Exemplo 5.6
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
            float nota;
            Console.Write("Insira a nota que obteve no exame: ");
            nota = Convert.ToSingle(Console.ReadLine());
            if (nota >= 9.5)
                Console.WriteLine("Aprovado.");
            else
                Console.WriteLine("Reprovado.");
        }
    }
}
