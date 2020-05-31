/*
 * Exemplo 8.11
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Alterar(int[] pArray)
        {
            pArray[0] = 888;  // Esta alteracao muda o valor original do vetor
            pArray = new int[5] { -3, -1, -2, -3, -4 };   // Esta alteracao e local
            Console.WriteLine("Metodo Alterar - Valor de arr[0] e: {0}", pArray[0]);
        }
        static void Main()
        {
            int[] arr = { 1, 4, 5 };
            Console.WriteLine("Metodo Main - Valor de arr[0] e: {0}", arr[0]);
            Alterar(arr);
            Console.WriteLine("Metodo Main - Valor de arr[0] e: {0}", arr[0]);
        }
    }
}
