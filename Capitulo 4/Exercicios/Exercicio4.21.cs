/*
 * Exercicio 4.21
 * Enunciado:   Escreva um programa que calcule a despesa média diária que um turista despendeu numa viagem de quatro dias ao Porto, sabendo que cada 
                dia gastou mais 20\% do que no dia anterior. O valor da despesa deverá ser apresentado sem casas decimais.
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
            double p,t;
            Console.Write("Qual foi a despesa do 1º dia: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            p = Convert.ToSingle(Console.ReadLine());
            t = p * (1 + 1.2 + 1.2 * 1.2 + 1.2 * 1.2 * 1.2) / 4;
            Console.WriteLine("Média diária dos 4 dias: {0:F0} ",t); 
        }
    }
}
