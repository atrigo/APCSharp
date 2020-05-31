/*
 * Exercicio 6.22
 * Enunciado:   Escreva um programa que peça a n pessoas de uma turma a sua idade. No final o programa deverá 
                verificar se a média de idade da turma varia entre 0 e 25, 26 e 60 e maior que 60; e então, 
                dizer se a turma é jovem, adulta ou idosa, conforme a média calculada.
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
            int n, idade, i, soma=0;
            Console.Write("Quantos alunos tem a turma: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (i = 1; i < n; i++)
                {
                    Console.Write("Introduza a idade do aluno: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    soma += idade;
                }
                if((float)soma/n <26)
                    Console.WriteLine("A turma é jovem"); 
                else
                    if((float)soma/n <=60)
                        Console.WriteLine("A turma é adulta"); 
                    else
                        Console.WriteLine("A turma é idosa"); 
            }
            else
                Console.WriteLine("A turma não tem alunos"); 
        }
    }
}
