/*
 * Exercicio 6.8
 * Enunciado:   Escreva um programa que leia uma sequência de números inteiros a partir do teclado e acumule 
 *              unicamente a soma dos inteiros positivos. O programa termina quando o número lido for zero.
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
            int n, soma=0;
            do
            {
                Console.Write("Introduza um nº inteiro (zero para sair): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    soma += n;
            } while (n != 0); 
            Console.WriteLine("Soma dos inteiros positivos: {0}",soma); 
        }
    }
}

