/*
 * Exercício 8.31
 * Livro: Aprenda a programar com C#
 * Autores: António Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/
using System;

namespace Cap8
{
    class Program
    {
        static int PesquisaBinaria(int[] v,int primeiro, int ultimo, int numero)
        {
            if (ultimo >= primeiro){
                int meio = primeiro + (ultimo - primeiro)/2;
                
                if (v[meio] == numero)
                    return meio;
                
                if (v[meio] > numero )
                    return PesquisaBinaria(v, primeiro, meio - 1, numero);
                    
                return PesquisaBinaria(v, meio + 1, ultimo , numero);
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
            int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Indique um numero a pesquisar?");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O numero {0} tem o indice {1} no vetor.",numero, PesquisaBinaria(v, 0, v.Length - 1, numero));
        }
    }
}
