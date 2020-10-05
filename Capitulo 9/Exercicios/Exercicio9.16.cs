/*
 * Exercicio 9.16
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static string iniciais(string a)
        {
            if (a.Length != 0)
            {
                int k = 0;
                char[] v = new char[a.Length];
                v[k++] = a[0];
                v[k++] = '.';
                for (int i = 1; i < a.Length; i++)
                    if (a[i] == ' ')
                    {
                        v[k++] = a[i + 1];
                        v[k++] = '.';
                    }
                Array.Resize(ref v, k);
                return new string(v);
            }
            else
                return a;
        }

        static void Main(string[] args)
        {
            string nome;
            Console.Write("Introduza um nome: ");
            nome = Console.ReadLine();
            Console.WriteLine(iniciais( nome));
        }
    }
}
