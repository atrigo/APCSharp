/*
 * Exercicio 6.25
 * Enunciado:   Escreva um programa que calcule o número médio de alunos por turma. 
 *              Para isto, peça a quantidade de turmas e a quantidade de alunos de cada turma. 
 *              As turmas não podem ter mais de 30 alunos.
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
            int n, num, soma=0;
            Console.Write("Quantas turmas? ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i <= n; i++)
            {
                do
                {
                    Console.Write("Quantos alunos tem a turma {0}? ",i);
                    num = Convert.ToInt32(Console.ReadLine());
                } while (num<1 || num > 30);// o nº de alunos por turma deve estar entre 1 e 30
                soma += num;
            }
            Console.WriteLine("Média de alunos por turma: {0}",soma/(float)n); // O type cast (float)n garante que a divisão é real
        }
    }
}
