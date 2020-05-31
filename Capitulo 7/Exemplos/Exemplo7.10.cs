/*
 * Exemplo 7.10
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0) //Criterio de paragem
                return 0;
            else
                if (n == 1) //Criterio de paragem
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Insira o n-esimo termo da serie de Fibonacci:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("F({0})={1}", n, Fibonacci(n));
        }
    }
}
