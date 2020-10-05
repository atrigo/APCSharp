/*
 * Exercicio 9.3
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
            for (int i = 0; i < s.Length; i++)
                if (s[i] == c)
                    return i;
            return -1;//Se o carácter não existir devolve -1
        }
        static void Main(string[] args)
        {
            string s;
            char c;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            Console.Write("Introduza o carácter a pesquisar: ");
            c = Convert.ToChar(Console.ReadLine());
            if(pesquisa(s,c)==-1)
                Console.WriteLine("O carácter {0} não existe na string", c);
            else
                Console.WriteLine("O carácter {0} aparece no índice {1}", c,pesquisa(s,c));
        }
    }
}
