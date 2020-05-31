
/*
 * Exercicio 4.8
 * Enunciado: Escreva um programa que leia do utilizador 3 números e os apresente alinhados à direita, na mesma linha, cada um com 10 casas.
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
            Console.WriteLine("{0,10}{1,10}{2,10}", a,b,c);// São reservados 10 caracteres para escrever cada número - alinhamento à direita
        }
    }
}
