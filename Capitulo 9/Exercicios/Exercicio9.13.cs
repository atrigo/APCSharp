/*
 * Exercicio 9.13
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;

namespace Cap9
{
    class Program
    {
        static string ultimaPalavra(string s)
        {
            int i = 0,j =s.Length-1,k=0;
            char[] v=new char[s.Length];
            while (j >= 0 && s[j] != ' ')// Pesquisa o 1º espaço, do fim para o princípio, ou o eventual fim da string se ela só tiver uma palavra
                j--;
            for (i = j+1 ; i < s.Length; i++)
                v[k++] = s[i];
            Array.Resize(ref v, s.Length - j - 1);
            return new string(v);
        }

        static void Main(string[] args)
        {
            string s;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            Console.WriteLine(ultimaPalavra( s));
        }
    }
}
