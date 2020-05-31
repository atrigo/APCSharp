/*
 * Exercicio 6.41
 * Enunciado:   Escreva um programa que leia 15 números entre 15 e 50 (os números lidos devem ser validados) 
 *              e apresente a soma dos números primos lidos.
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
            int n, i,j,soma=0; 
            for (j = 0; j < 15; j++)
            {
                do
                {
                    Console.Write("Introduza um nº inteiro entre 15 e 50: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n < 15 || n > 50);
                for (i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0)
                        break;
                if (i > Math.Sqrt(n))
                    soma+=n;
            }
            Console.WriteLine("Soma: {0}",soma);
        }
    }
}
