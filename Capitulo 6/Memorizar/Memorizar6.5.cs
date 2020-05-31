/*
 * Memorizar 6.5
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
            int numero, contar = 0;
            do
            {
                Console.WriteLine("Insira um numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero != 0)
                    contar++;
            } while (numero != 0);
            Console.WriteLine("Foram inseridos {0} numeros.", contar);
        }
    }
}
