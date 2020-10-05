/*
 * Exemplo 9.1
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
            string frase = "Bom dia!";
            //Diretamente
            Console.WriteLine(frase);
            //Utilizando um ciclo for
            for (int i = 0; i < frase.Length; i++)
                Console.Write("{0}", frase[i]);
            Console.WriteLine();
        }
    }
}
