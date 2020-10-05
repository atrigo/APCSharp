/*
 * Exemplo 9.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int i = 0, j = 0;
            Console.Write("Insira uma frase: ");
            frase = Console.ReadLine();
            char[] charsFrase = new char[frase.Length];
            for (i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    charsFrase[j] = frase[i];
                    j++;
                }
            }
            frase = new string(charsFrase);
            Console.WriteLine(frase);
        }
    }
}
