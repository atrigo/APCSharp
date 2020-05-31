/*
 * Exemplo 8.5
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
            int[] v = new int[] { 3, 7, 4, 9, 2, 6, 7, 8, 9, 2 };
            int posMenor = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < v[posMenor])
                    posMenor = i;
            }
            Console.WriteLine("Resultado: Valor: {0}, Indice: {1}", v[posMenor], posMenor);
        }
    }
}
