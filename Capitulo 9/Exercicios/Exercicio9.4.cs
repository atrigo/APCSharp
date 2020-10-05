/*
 * Exercicio 9.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static int pesquisa(string s, char c)
        {
            int contador = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == c)
                    contador++;
            return contador;
        }
        static void Main(string[] args)
        {
            string s;
            char c;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            Console.Write("Introduza o carácter a pesquisar: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("O carácter '{0}' aparece {1} vez(es)", c,pesquisa(s,c));
        }
    }
}
