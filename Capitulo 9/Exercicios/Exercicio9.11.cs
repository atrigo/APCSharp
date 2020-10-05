/*
 * Exercicio 9.11
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void eliminaPrimeiraPalavra(ref string s)
        {
            int i = 0,j = 0,k=0;
            char[] v=new char[s.Length];
            while (j < s.Length && s[j] != ' ')// Pesquisa o 1º espaço ou o eventual fim da string se ela só tiver uma palavra
                j++;
            if (j < s.Length) // Testa se a string tem apenas uma palavra
            {
                for (i = j + 1; i < s.Length; i++)
                    v[k++] = s[i];
                Array.Resize(ref v, s.Length - j - 1);
                s = new string(v);
            }
            else
                s = "";
        }

        static void Main(string[] args)
        {
            string s;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            eliminaPrimeiraPalavra(ref s); // Sem a utilização da passagem por referência as alterações efectuadas no método insereAster não se refectiriam na função main
            Console.WriteLine(s);
        }
    }
}
