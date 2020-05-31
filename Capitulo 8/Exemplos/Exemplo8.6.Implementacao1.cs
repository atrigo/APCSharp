/*
 * Exemplo 8.6 - Implementacao 1
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
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = new int[a.Length];

            b = a;
            //Se alterar o valor em a vai aparecer alterado em b
            //Trata-se por isso do mesmo valor e nao de uma copia
            a[0] = 10;
            Console.WriteLine("a[0]:{0} b[0]:{1}", a[0], b[0]);
        }
    }
}
