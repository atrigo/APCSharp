/*
 * Exemplo 9.3
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
            string frase1 = "C#";
            string frase2 = "C#";
            string frase3 = "c#";
            Console.WriteLine(frase1.Equals("C#")); //True
            Console.WriteLine(frase1.Equals(frase2)); //True
            Console.WriteLine(frase1.Equals(frase3)); //False
            Console.WriteLine(frase1 == "C#"); //True
            Console.WriteLine(frase1 == frase2); //True
            Console.WriteLine(frase1 == frase3); //False
        }
    }
}
