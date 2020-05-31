/*
 * Exemplo 6.7
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
            int asteriscos, i, j;
            Console.Write("Quantos asteriscos deseja para o quadrado?");
            asteriscos = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < asteriscos; i++)
            {
                for (j = 0; j < asteriscos; j++)
                    if (i == 0 || i == asteriscos - 1 || j == 0 || j == asteriscos - 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                Console.WriteLine();
            }
        }
    }
}
