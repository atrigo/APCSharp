/*
 * Exercicio 6.39
 * Enunciado:   Escreva um programa que determine o maior número ímpar e o menor par introduzidos pelo utilizador. 
                A introdução de números pelo utilizador termina quando for introduzido um número negativo.
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
            int n, maiorImpar = 1, menorPar = int.MaxValue - 1, i = 0, p = 0;
            Console.Write("Introduza um nº inteiro: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n >= 0)
            {
                if (n % 2 == 0)
                {
                    p++;
                    if (n < menorPar)
                        menorPar = n;
                }
                else
                {
                    i++;
                    if (n > maiorImpar)
                        maiorImpar = n;
                }
                Console.Write("Introduza um nº inteiro: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            if (p == 0)
                Console.WriteLine("Não foram introduzidos nºs pares");
            else
                Console.WriteLine("Foram introduzidos {0} pares sendo o menor {1}", p, menorPar);
            if (i == 0)
                Console.WriteLine("Não foram introduzidos nºs impares");
            else
                Console.WriteLine("Foram introduzidos {0} impares sendo o maior {1}", i, maiorImpar);
        }
    }
}
