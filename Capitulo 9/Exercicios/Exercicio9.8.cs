/*
 * Exercicio 9.8
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void insereAster(ref string s)
        {
            int i = 0;
            char[] v=new char[s.Length*2];
            for (int j = 0; j <s.Length ; j++)
            {
                v[i++] = s[j];
                v[i++] = '*';
            }
            s = new string(v);
        }
        static void Main(string[] args)
        {
            string s;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            insereAster(ref s); // Sem a utilização da passagem por referência as alterações efectuadas no método insereAster não se refectiriam na função main
            Console.WriteLine(s);
        }
    }
}
