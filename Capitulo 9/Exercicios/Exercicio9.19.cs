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
            {
                if (s[i]>='A' && s[i] <= 'Z')
                    if (s[i] + x > 'Z')
                        v[i] = (char)('A' + (s[i] + x - 'Z') - 1);
                    else
                        v[i] = (char)(s[i] + x);

                if (s[i] >= 'a' && s[i] <= 'z')    
                    if (s[i] + x > 'z')
                        v[i] = (char)('a' + (s[i] + x - 'z') - 1);
                    else
                        v[i] = (char)(s[i] + x);
            }
            return new string(v);
        }

        static string desencriptar(string s, int x)
        {
            char[] v = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                    if (s[i] - x < 'A')
                        v[i] = (char)('Z' - ('A' - (s[i] - x)) + 1);
                    else
                        v[i] = (char)(s[i] - x);

                if (s[i] >= 'a' && s[i] <= 'z')
                    if (s[i] - x < 'a')
                        v[i] = (char)('z' - ('a' - (s[i] - x)) + 1);
                    else
                        v[i] = (char)(s[i] - x);
            }
            return new string(v);
        }

        static void Main(string[] args)
        {
            string s, e;
            int x = 3;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            e = encriptar(s, x);
            Console.WriteLine("Frase encriptada: {0}", e);
            Console.WriteLine("Frase desencriptada: {0}", desencriptar(e, x));
        }
    }
}
