
/*
 * Exercicio 4.11
 * Enunciado: Escreva um programa que peça dois números ao utilizador e apresente a sua soma.
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
            float a,b;
            Console.Write("Introduza um número: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza um número: "); 
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}",a,b,a+b); 
        }
    }
}
