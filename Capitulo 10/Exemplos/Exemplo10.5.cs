/*
 * Exemplo 10.5
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
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 5) throw new Exception();
                Console.WriteLine("O numero inserido foi {0}", i);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("O programa esperava um numero inteiro.");
            }
            catch
            {
                Console.WriteLine("Tem de introduzir um numero diferente de 5.");
            }
            finally
            {
                Console.WriteLine("O programa vai terminar.");
            }
        }
    }
}
