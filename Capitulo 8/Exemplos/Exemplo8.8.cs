/*
 * Exemplo 8.8
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 3, 7, 4, 9, 2, 6, 7, 8, 9, 2 };

            Console.WriteLine("Soma dos valores: {0}", v.Sum());
            Console.WriteLine("Media dos valores: {0}", v.Average());
            Console.WriteLine("Valor minimo: {0}", v.Min());
            Console.WriteLine("Valor maximo: {0}", v.Max());
            if (v.Contains(5))
                Console.WriteLine("O vetor contem o numero 5.");
        }
    }
}
