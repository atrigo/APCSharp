/*
 * Memroizar 7.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static int Fatorial(int n)
        {
            if (n == 1) //Criterio de paragem
                return n;
            else
                return n * Fatorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Insira o numero cujo fatorial deseja calcular:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}!={1}", n, Fatorial(n));
        }
    }
}
