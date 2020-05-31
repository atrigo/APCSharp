/*
 * Exercicio 7.11
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static uint numDigitos(uint n)
        {
            uint contador = 0;
            do
            {
                n = n / 10;
                contador++;
            } while (n != 0);
            return contador;
        }
        static void Main(string[] args)
        {
            uint N;
            Console.Write("Introduza um nº inteiro positivo: ");
            N = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("O número {0} tem {1} dígitos", N, numDigitos(N));
        }
    }
}
