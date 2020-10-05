/*
 * Exercicio 9.17
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static bool pesquisa(string a, string s)
        {
            int j;
            if (s.Length <= a.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (j = 0; j < s.Length; j++)
                        if (a[i + j] != s[j])
                            break;
                    if (j == s.Length)
                        return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            string A, S;
            Console.Write("Introduza uma frase: ");
            A = Console.ReadLine();
            Console.Write("Introduza a frase a pesquisar: ");
            S = Console.ReadLine();
            if (pesquisa(A,S))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("Não existe");
        }
    }
}
