/*
 * Exercicio 6.27
 * Enunciado: Escreva um programa que converta um número decimal em binário.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n, soma = 0, i = 0;
            Console.Write("Introduza um número decimal? ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                soma += n % 2 * (int)Math.Pow(10, i++);
                n = n / 2;
            } while (n > 0);
            Console.WriteLine("Binário: {0}",soma);
        }
    }
}
