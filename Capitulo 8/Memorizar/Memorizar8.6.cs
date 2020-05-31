/*
 * Memorizar 8.6
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
                       int[] v = new int[] { 2,2, 3,4,6,7,7,8,9,9};
            int numPesquisar = 7;
            bool encontrou = false;

            int limInferior = 0;
            int limSuperior = v.Length - 1;
            int meio;

            while (limInferior <= limSuperior) {
                meio = (limInferior + limSuperior) / 2;
                if (numPesquisar == v[meio])
                    encontrou = true;
                if (numPesquisar < v[meio])
                    limSuperior = meio - 1;
                else
                    limInferior = meio + 1;
            }
            Console.WriteLine("O valor {0} esta presente no " + 
            "vetor? {1}",numPesquisar,encontrou);
        }
    }
}
