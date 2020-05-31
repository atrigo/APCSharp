/*
 * Exercicio 4.23
 * Enunciado:   Escreva um programa que troque entre si o valor contido em duas variáveis inteiras a e b, 
 *              ou seja, o valor contido em a passa a ser o valor de b e vice-versa, sem utilizar uma terceira variável.
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
            int a=4,b=5;
            Console.WriteLine("a:{0}\tb:{1}",a,b); //faça execução passo a passo (F10) para ver a evolução do conteúdo das variáveis
            a = a + b; // a=9 b=5
            b = a - b; // a=9 b=4
            a = a - b; // a=5 b=4
            Console.WriteLine("a:{0}\tb:{1}",a,b);
        }
    }
}
