/*
 * Exercicio 9.14
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static bool palindromo(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            string s;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            if(palindromo(s))
                Console.WriteLine("É um palíndromo");
            else
                Console.WriteLine("Não é um palíndromo");
        }
    }
}
