/*
 * Exercicio 6.31
 * Enunciado: Escreva um programa que converta a numeração Romana em Árabe.
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
            int num = 0, i = 0, soma = 0, ant = 0;
            string romano;
            Console.Write("Introduza um número romano: ");// A correção do número romano não é validada
            romano = Console.ReadLine();
            for (i = 0; i < romano.Length; i++)
            {
                switch (romano[i])
                {
                    case 'M': num = 1000; break;
                    case 'D': num = 500; break;
                    case 'C': num = 100; break;
                    case 'L': num = 50; break;
                    case 'X': num = 10; break;
                    case 'V': num = 5; break;
                    case 'I': num = 1; break;
                    default: num = 0;
                            Console.WriteLine("Número inválido");
                            return; //O programa termina a execução neste ponto, em alternativa poderia ter usado goto
                }
                if (ant < num)
                    soma += num - 2 * ant;
                else
                    soma += num;
                ant = num;
            }
            Console.WriteLine("Árabe: {0}", soma);
        }
    }
}
