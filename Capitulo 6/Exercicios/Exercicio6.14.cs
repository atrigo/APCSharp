/*
 * Exercicio 6.14
 * Enunciado:   Escreva um programa que mostre os n termos da seguinte série: S = 1/1 + 2/3 + 3/5 + 4/7 + 5/9 + ... + n/m. 
                Imprima no final a soma da série.
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
            int N, n = 1, m = 1;
            float soma = 0;
            Console.Write("Quantos termos? ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("S=");
            do
            {
                soma += (float)n / m; // ou soma=soma + (float)n/m
                Console.Write("{0}/{1}+", n, m);
                n++;
                m = m + 2;// ou m+=2
            } while (n < N);
            Console.WriteLine("{0}/{1}\nsoma={2}", n, m, soma += (float)n / m);
        }
    }
}
