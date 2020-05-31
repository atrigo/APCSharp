/*
 * Exercicio 6.10
 * Enunciado: Escreva um programa que leia um número inteiro e calcule a soma dos seus dígitos.
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
            int n, soma = 0;
            Console.Write("Introduza um número inteiro: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0) // Sugestão: Faça execução passo a passo (F10) e observe os valores das variáveis na janela Locais
            {
                soma += n % 10; // O resto da divisão por 10 permite obter cada um dos dígitos do número
                n /= 10; // Depois da obtenção esse dígito é descartado
            }
            Console.WriteLine("Soma dos dígitos:{0}", soma);
        }
    }
}
