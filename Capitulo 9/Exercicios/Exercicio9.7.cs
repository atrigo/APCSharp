/*
 * Exercicio 9.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void substitui(ref string s, char c, int i, int j)
        {
            char[] v=s.ToCharArray();
            for (int k = i; k <= j; k++)
                v[k] = c;
            s= new string(v);
        }
        static void Main(string[] args)
        {
            string s;
            char c;
            int i,j;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            Console.Write("Introduza o carácter a inserir: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduza o índice da primeira posição: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o índice da última posição: ");
            j = Convert.ToInt32(Console.ReadLine());
            substitui(ref s, c, i,j); // Sem a utilização da passagem por referência as alterações efectuadas no método substitui não se refectiriam na função main
            Console.WriteLine(s);
        }
    }
}
