/*
 * Exercicio 6.1
 * Enunciado: Escreva um programa que imprima no ecrã um retângulo com o símbolo ``X'' sabendo a sua largura e comprimento.
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
            int i, j, l, c;
            Console.Write("Introduza a largura: ");     // Não é feita validação, ou seja, o utilizador pode 
            l = Convert.ToInt32(Console.ReadLine());    // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o comprimento: ");
            c = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < l; i++) // largura do retângulo (nº de linhas = l)
            {
                for (j = 0; j < c; j++) // comprimento do retângulo (nº de colunas = c)
                    Console.Write("X");
                Console.WriteLine();    // muda de linha quando termina de escrever todas as colunas
            }
        }
    }
}
