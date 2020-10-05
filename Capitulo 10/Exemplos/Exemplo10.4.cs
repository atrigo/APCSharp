/*
 * Exemplo 10.4
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
            int[] array = { 0, 0, 0 };
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("array[{0}] = {1}", i, array[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Erro: {0}", e);
            }
        }
    }
}
