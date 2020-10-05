/*
 * Exemplo 10.2
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
            while (true)
            {
                try
                {
                    Console.Write("Insira um numero real:");
                    double numero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O qudrado do numero inserido e: {0}", Math.Pow(numero, 2));
                }
                catch (FormatException)
                {
                    Console.WriteLine("O numero inserido nao e real.");
                    continue;
                }
                break;
            }
        }
    }
}
