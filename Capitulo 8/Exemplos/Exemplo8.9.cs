/*
 * Exemplo 8.9
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
            int[,] m = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(m[2, 1]); //Mostra o elemento 6
            Console.Write("Insira um valor para o primeiro indice:");
            m[0, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m[0, 0]); //Mostra o valor inserido
        }
    }
}
