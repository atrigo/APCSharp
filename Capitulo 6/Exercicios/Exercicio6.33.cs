/*
 * Exercicio 6.33
 * Enunciado:   Um número perfeito é um número inteiro positivo para o qual a soma de todos os seus divisores 
 *              inteiros positivos próprios (excluindo ele mesmo) é igual ao próprio número. Escreva um programa 
 *              que apresente no ecrã todos os números perfeitos até 10000.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
 *   
  Um número perfeito é um número natural para o qual a soma de todos os seus divisores
  naturais próprios (excluindo ele mesmo) é igual ao próprio número. 
  Exemplos de números perfeitos: 6, 28, 496, 8128, ...
*/
using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) 
        {
            int j,n,soma;
            for (n = 2; n < 10000; n++)
            {
                soma = 1;
                for (j = 2; j <= (Math.Sqrt((float)n)); j++)
                    if (n % j == 0)
                        if (j == n / j)
                            soma += j;
                        else
                            soma += j + n / j;
                if (soma == n)
                    Console.WriteLine(n);
            }
        }
    }
}
