/*
 * Memorizar 6.6
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
            int numero, somar = 0;
            do
            {
                Console.WriteLine("Insira um numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero != 0)
                    somar += numero;
            } while (numero != 0);
            Console.WriteLine("A soma dos numeros e {0}.", somar);
        }
    }
}
