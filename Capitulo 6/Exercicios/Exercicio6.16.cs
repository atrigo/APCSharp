/*
 * Exercicio 6.16
 * Enunciado:   O dono de um hotel concebeu uma forma original de cobrar aos seus clientes. A primeira noite custa 50 euros. 
 *              A segunda custa 25 euros (ou seja, 50\2 euros), a terceira 50\3 euros e a n-ésima noite custa 50\n euros. 
 *              Escreva um programa que calcule a cobrança a efetuar a um cliente que fique X noites no hotel. 
 *              O programa deve indicar o preço a pagar por cada noite e também o total.
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
            int N, n;
            double soma = 0;
            Console.Write("Quantas noites:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("S=");
            for (n = 1; n < N; n++)
            {
                soma += 50F / n;
                Console.Write("{0}/{1}+", 50, n);
            }
            Console.WriteLine("{0}/{1}\nSoma={2}", 50, n, soma += 50F / n);
        }
    }
}
