/*
 * Exemplo 7.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void IntFrac(float x)
        {
            Console.Write("Parte inteira: {0} \n", (int)x);
            Console.Write("Parte fracionaria: {0:F3}\n", x - (int)x);
        }

        static void Main(string[] args)
        {
            float num;
            Console.Write("Escreva um numero real: ");
            num = Convert.ToSingle(Console.ReadLine());
            IntFrac(num);
        }
    }
}
