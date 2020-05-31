/*
 * Exercicio 6.28
 * Enunciado: Escreva um programa que converta um número binário num número decimal.
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
            Console.Write("Introduza um número binário? "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos e gerar excepções (ERROS)
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                soma += n % 10 * (int)Math.Pow(2, i++);
                n = n / 10;
            } while (n > 0);
            Console.WriteLine("Decimal: {0}",soma);
        }
    }
}
