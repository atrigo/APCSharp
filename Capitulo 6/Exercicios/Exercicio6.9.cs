/*
 * Exercicio 6.9
 * Enunciado: Escreva um programa que peça a altura de $n$ alunos de uma turma e apresente as seguintes estatísticas:
 *  	            - A altura do aluno mais baixo;
 *		            - A altura do aluno mais alto;
 *		            - A soma das alturas;
 *		            - A médias das alturas.
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
            int n, a, i, max, min, soma=0;
            Console.Write("Quantos alunos tem a turma: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.Write("Introduza a altura do aluno em cm: ");
                a = Convert.ToInt32(Console.ReadLine());
                max = a;
                min = a;
                soma += a;
                for (i = 1; i < n; i++)
                {
                    Console.Write("Introduza a altura do aluno em cm: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a > max)
                        max = a;
                    if (a < min)
                        min = a;
                    soma += a;
                }
                Console.WriteLine("Máximo: {0}\nMínimo: {1}\nSoma: {2}\nMédia: {3}",max,min,soma,soma/(float)n); // O type cast (float)n garante que a divisão é real
            }
            else
                Console.WriteLine("A turma não tem alunos"); 
        }
    }
}

