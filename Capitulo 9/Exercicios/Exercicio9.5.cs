/*
 * Exercicio 9.5
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static string concatena(string a, string b)
        {
            return a+b;
        }
        static void Main(string[] args)
        {
            string s1,s2;
            Console.Write("Introduza uma frase: ");
            s1 = Console.ReadLine();
            Console.Write("Introduza outra frase: ");
            s2 = Console.ReadLine();
            Console.WriteLine(concatena(s1,s2));
        }
    }
}
