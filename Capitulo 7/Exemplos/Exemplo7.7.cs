/*
 * Exemplo 7.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void MostraNumeros(int inicio = 20, int fim = 30)
        {
            for (int i = inicio; i <= fim; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            MostraNumeros(1, 10);
            MostraNumeros(25);
            MostraNumeros();
            MostraNumeros(fim: 20, inicio: 10);
        }
    }
}
