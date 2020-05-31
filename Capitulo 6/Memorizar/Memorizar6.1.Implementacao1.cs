/*
 * Memorizar 6.1 - Implementacao 1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
 *
 * Enunciado: Escreva um programa que avalie de um número introduzido por um utilizador é ou não um número primo. 
 *
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.Write("Insira um numero:");
            num = Convert.ToInt32(Console.ReadLine());
            bool eprimo = true;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                    eprimo = false;
            }
            if (eprimo)
                Console.WriteLine("O numero {0} e primo.", num);
            else
                Console.WriteLine("O numero {0} nao e primo.", num);
        }
    }
}
