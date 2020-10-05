/*
 * Exemplo 10.1
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
            try
            {
                Console.WriteLine("Insira um numero inteiro:");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("O numero inserido foi {0}", numero);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("O programa esperava um numero inteiro.");
            }
            finally
            {
                Console.WriteLine("O programa vai terminar.");
            }
        }
    }
}
