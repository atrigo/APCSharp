/*
 * Exemplo 8.4
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
            int indice = -1;
            int numPesquisar = 7;
            int[] v = new int[] { 3,7,4,9,2,6,7,8,9,2};
            for (int i = 0; i < v.Length; i++){
                if (v[i] == numPesquisar){
                    indice = i;
                    break;
                }
            }
            Console.WriteLine("Indice: {0}", indice);
        }
    }
}
