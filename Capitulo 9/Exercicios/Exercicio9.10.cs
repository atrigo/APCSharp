/*
 * Exercicio 9.10
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void inverte(ref string s)
        {
            char aux;
            char[] v=s.ToCharArray();
            for (int j = 0; j <s.Length/2 ; j++)
            {
                aux = v[j];
                v[j] = v[s.Length-1-j];
                v[s.Length-1-j]=aux;
            }
            s = new string(v);
        }
        static void Main(string[] args)
        {
            string s;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            inverte(ref s); // Sem a utilização da passagem por referência as alterações efectuadas no método insereAster não se refectiriam na função main
            Console.WriteLine(s);
        }
    }
}
