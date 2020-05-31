/*
 * Exercicio 6.13
 * Enunciado: Escreva um programa que determine os divisores de um número inteiro introduzido pelo utilizador.
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
            int n, i;
            Console.Write("Digite um nº inteiro:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*** Divisores de {0} ***",n);
            for (i = 1; i <= Math.Sqrt(n); i++) // Podemos encontrar todos os divisores de um número testando até à raiz quadrada desse número
                if (n % i == 0)
                    if (i == n / i)
                        Console.WriteLine(" {0,6}", i); // 1 divisor: i é a raiz quadrada de n
                    else
                        Console.WriteLine("{0,5} {1,5}", i, n / i); // 2 divisores: i e n/i
        }
    }
}
