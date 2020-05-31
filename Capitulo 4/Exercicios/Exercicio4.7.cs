
/*
 * Exercicio 4.7
 * Escreva um programa que leia do utilizador 3 números e os apresente alinhados à esquerda, na mesma linha, cada um com 10 casas.
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
            float a,b,c;
            Console.Write("Introduza um número: "); 
            a = Convert.ToSingle(Console.ReadLine());// Tenha em atenção que numa consola de Windows em Português o separador decimal é a vírgula
            Console.Write("Introduza um número: "); 
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza um número: "); 
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0,-10:F1}{1,-10:F1}{2,-10:F1}", a,b,c);// São reservados 10 caracteres para escrever cada número, o sinal - significa que o alinhamento é à esquerda
        }
    }
}
