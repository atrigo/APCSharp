/*
 * Exemplo 12.7
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
            Queue<string> filaClientes = new Queue<string>();
            filaClientes.Enqueue("um");
            filaClientes.Enqueue("dois");
            filaClientes.Enqueue("tres");
            Console.WriteLine("Numero de clientes na fila: {0}", filaClientes.Count);
            Console.WriteLine("A atender o cliente: {0}", filaClientes.Dequeue());
            Console.WriteLine("Numero de clientes na fila: {0}", filaClientes.Count);
            while (filaClientes.Count > 0)
            {
                Console.WriteLine("A atender o cliente: {0}", filaClientes.Dequeue());
            }
            Console.WriteLine("Numero de clientes na fila: {0}", filaClientes.Count);
            filaClientes.Enqueue("quatro");
            Console.WriteLine("Numero de clientes na fila: {0}", filaClientes.Count);
            //Verificar qual o elemento que esta na fila
            Console.WriteLine("Proximo cliente: {0}", filaClientes.Peek());
            Console.WriteLine("A atender o cliente: {0}", filaClientes.Dequeue());
            Console.WriteLine("Numero de clientes na fila: {0}", filaClientes.Count);
        }
    }
}
