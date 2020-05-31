
/*
 * Exercicio 4.2
 * Enunciado: Escreva um programa que apresente no ecrã o resultado da expressão 5/2. Analise o resultado.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5/2={0}",5/2); // divisão inteira porque quer o numerador quer o denominador são inteiros
            Console.WriteLine("5/2={0}",5/2.0); // divisão real porque o denominador é um nº real
            Console.WriteLine("5/2={0}",(float)5/2); // divisão real porque o numerador é um nº real, foi efectuado um type cast (conversão de tipo)
        }
    }
}
