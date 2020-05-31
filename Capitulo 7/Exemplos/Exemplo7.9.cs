/*
 * Exemplo 7.8
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static int Soma(int n)
        {
            if (n == 0) //Criterio de paragem
                return n;
            else
                return n + Soma(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Deseja fazer a soma de quantos numeros:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Soma: {0}", Soma(n));
        }
    }
}
