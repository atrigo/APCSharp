/*
 * Exercicio 9.19
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static string encriptar(string s, int x)
        {
            char[] v = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
                v[i] = (char)(s[i]+12);
            return new string(v);
        }

        static string desencriptar(string s, int x)
        {
            char[] v = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
                v[i] = (char)(s[i]-12);
            return new string(v);
        }

        static void Main(string[] args)
        {
            string s,e;
            int x = 12;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            e = encriptar(s,x);
            Console.WriteLine("Frase encriptada: {0}",e);
            Console.WriteLine("Frase desencriptada: {0}",desencriptar(e,x));
        }
    }
}
