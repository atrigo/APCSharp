/*
 * Exemplo 8.13
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;
namespace ConsoleApp1
{
    class Program
    {
        static void ApresentarVetor(int[] v)
        {
            Console.Write("Vetor: ");
            foreach (int elemento in v)
                Console.Write("{0} ", elemento);
            Console.WriteLine();
        }
        static void Main()
        {
            int[] arr = { 1, 4, 5 };
            ApresentarVetor(arr);
            Array.Resize(ref arr, 2);
            ApresentarVetor(arr);
            Array.Resize(ref arr, 6);
            ApresentarVetor(arr);
        }
    }
}
