/*
 * Exercicio 6.35
 * Enunciado: Escreva um programa que avalie se um NIF introduzido pelo utilizador é válido.
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
            int n, d = 0, i = 1, soma = 0;
            Console.Write("Introduza o número de identificação fiscal: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 9; i++)
            {
                d = n % 10;
                n = n / 10;
                if (i == 1 && d == 0)
                    soma = soma + 10;
                else
                    soma = soma + d * i;
            }
            if (soma % 11 != 0 || d == 3 || d == 4 || d == 7 || d == 0)
                Console.WriteLine("NIF Inválido\n");
            else
                Console.WriteLine("NIF Válido\n");
        }
    }
}
