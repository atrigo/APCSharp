/*
 * Exemplo 8.3
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
            bool encontrou = false;
            int numPesquisar = 7;
            int[] v = new int[] { 3,7,4,9,2,6,7,8,9,2};
            for (int i = 0; i < v.Length; i++) {
                if (v[i] == numPesquisar) {
                    encontrou = true;
                }
            }
            Console.WriteLine("O valor {0} esta presente " +
            "no vetor?{1}",numPesquisar,encontrou);
        }
    }
}
