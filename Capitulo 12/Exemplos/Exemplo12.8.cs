/*
 * Exemplo 12.8
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
        static void Main(string[] args)
        {
            Stack<string> pilhaDePratos = new Stack<string>();
            Console.WriteLine("Adicionar tres pratos a pilha.");
            pilhaDePratos.Push("1");
            pilhaDePratos.Push("2");
            pilhaDePratos.Push("3");
            Console.WriteLine("Numero de pratos na pilha: {0}.", pilhaDePratos.Count);
            Console.WriteLine("Retirar o prato {0} que esta no topo da pilha.", pilhaDePratos.Pop());
            Console.WriteLine("Numero de pratos na pilha: {0}.", pilhaDePratos.Count);
            Console.WriteLine("Espreitar o prato que esta no topo da pilha: {0}.", pilhaDePratos.Peek());
            Console.WriteLine("Retirar o prato {0} que esta no topo da pilha.", pilhaDePratos.Pop());
            Console.WriteLine("Numero de pratos na pilha: {0}.", pilhaDePratos.Count);
            Console.WriteLine("Adicionar o prato 4 a fila.");
            pilhaDePratos.Push("4");
            Console.WriteLine("Numero de pratos na pilha: {0}", pilhaDePratos.Count);
            Console.WriteLine("Retirar o prato {0} que esta no topo da pilha.", pilhaDePratos.Pop());
            Console.WriteLine("Retirar o prato {0} que esta no topo da pilha.", pilhaDePratos.Pop());
            Console.WriteLine("Numero de pratos na pilha: {0}", pilhaDePratos.Count);

        }
    }
}