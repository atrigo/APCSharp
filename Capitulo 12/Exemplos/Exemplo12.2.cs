/*
 * Exemplo 12.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void ApresentarLista(List<int> lInt)
        {
            Console.Write("Vetor: ");
            foreach (int elemento in lInt)
                Console.Write("{0} ", elemento);
            Console.WriteLine();
        }
        static void Main()
        {
            List<int> listaInteiros = new List<int>(); //Cria a lista de inteiros
            for (int i = 0; i < 10; i++) //Adiciona elementos a lista
                listaInteiros.Add(10 - i);
            ApresentarLista(listaInteiros);
            listaInteiros[3] = 4; //Altera um valor na lista
            ApresentarLista(listaInteiros);
            listaInteiros.RemoveAt(3); //Remove um valor da lista
            ApresentarLista(listaInteiros);
            listaInteiros.Sort(); //Ordena os elementos da lista
            ApresentarLista(listaInteiros);
        }
    }
}