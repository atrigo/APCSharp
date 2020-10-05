/*
 * Exercicio 9.15
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static string funde(string a, string b)
        {
            int k=0;
            char[] v=new char[a.Length*2];
            for (int i = 0 ; i < a.Length; i++)
            {
                v[k++] = a[i];
                v[k++] = b[i];
            }
            return new string(v);
        }

        static void Main(string[] args)
        {
            string A,B;
            Console.Write("Introduza uma frase: ");
            A = Console.ReadLine();
            Console.Write("Introduza outra frase: ");
            B = Console.ReadLine();
            if(A.Length==B.Length)
                Console.WriteLine(funde( A,B));
            else
                Console.WriteLine("As frases não têm o mesmo tamanho");
        }
    }
}
