/*
 * Exercicio 9.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

//Versao 1
using System;

namespace Cap9
{
    class Program
    {
        static void insere(ref string s, char c, int i)
        {
            char[] v=new char[s.Length+1];
            for (int j = 0; j < i; j++)
                v[j] = s[j];
            v[i] = c;
            for (int j = i; j < s.Length; j++)
                v[j+1] = s[j];
            s = new string(v);
        }
        static void Main(string[] args)
        {
            string s;
            char c;
            int i;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            Console.Write("Introduza o carácter a inserir: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduza o índice no qual pretende inserir: ");
            i = Convert.ToInt32(Console.ReadLine());
            insere(ref s, c, i); // Sem a utilização da passagem por referência as alterações efectuadas no método insere não se refectiriam na função main
            Console.WriteLine(s);
        }
    }
}


//Versao 2

using System;

namespace Cap9
{
    class Program
    {
        static string insere(string s, char c, int i)// Nesta versão do exercício o método devolve uma nova string
        {
            char[] v=new char[s.Length+1];
            for (int j = 0; j < i; j++)
                v[j] = s[j];
            v[i] = c;
            for (int j = i; j < s.Length; j++)
                v[j+1] = s[j];
            return new string(v);
        }
        static void Main(string[] args)
        {
            string s;
            char c;
            int i;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            Console.Write("Introduza o carácter a inserir: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("Introduza o índice no qual pretende inserir: ");
            i = Convert.ToInt32(Console.ReadLine());
            s=insere(s, c, i); 
            Console.WriteLine(s);
        }
    }
}
