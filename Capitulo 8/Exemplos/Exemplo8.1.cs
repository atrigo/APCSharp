/*
 * Exemplo 8.1
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
            int[] a = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine(a[3]); //Mostra o elemento 40
            Console.Write("Insira um valor para a terceira posicao:");
            a[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a[2]); //Mostra o valor inserido
        }
    }
}
