/*
 * Exercicio 6.4
 * Enunciado:   Escreva um programa que receba dois números inteiros e gere os números inteiros 
 *              que estão no intervalo compreendido por eles.
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
            int inf, sup, i;
            Console.Write("Introduza o limite inferior do intervalo: ");     // Não é feita validação, ou seja, o utilizador pode 
            inf = Convert.ToInt32(Console.ReadLine());                        // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o limite superior do intervalo: ");
            sup = Convert.ToInt32(Console.ReadLine());
            for (i = inf; i <= sup; i++) // ciclo com i a variar entre inf e sup
                Console.Write("{0} ",i);
            Console.WriteLine();    // muda de linha quando termina de escrever todos os números
        }
    }
}
