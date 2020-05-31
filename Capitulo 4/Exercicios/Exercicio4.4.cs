
/*
 * Exercicio 4.4
 * Enunciado: Escreva um programa que apresente no ecrã a parte inteira de um número introduzido pelo utilizador.
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
            float r;
            Console.Write("Introduza um número real: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            r = Convert.ToSingle(Console.ReadLine());// Tenha em atenção que numa consola de Windows em Português o separador decimal é a vírgula
            Console.WriteLine("A parte inteira de {0} é {1}",r,(int)r); // utilizou-se uma conversão de tipo (type cast)
        }
    }
}
