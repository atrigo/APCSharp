
/*
 * Exemplo 8.6 - Implementacao 2
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

            //Ciclo para copiar todos os elementos
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            //O vetor b e uma copia do vetor a
            //Se alterar o valor em a ja nao vai aparecer alterado em b
            a[0] = 10;
            Console.WriteLine("a[0]:{0} b[0]:{1}", a[0], b[0]);
        }
    }
}
