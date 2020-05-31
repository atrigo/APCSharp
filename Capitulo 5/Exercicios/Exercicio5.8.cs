/*
 * Exercicio 5.8 - Determine se um ano é Bissexto
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap5
{
    class Program               //Um ano é bissexto se for divisível por 400 ou se for divisível por 4 e não por 100.
    {
        static void Main(string[] args) 
        {
            int ano;
            Console.Write("Introduza o ano: ");        // Não é feita validação, ou seja, o utilizador pode introduzir valores fora 
            ano = Convert.ToInt32(Console.ReadLine());// da gama permitida ou caracteres inválidos e como tal gerar excepções (ERROS)
            if((ano%400 ==0 || ano%4==0) && ano%100 !=0) // Note que os parênteses na conjunção (&&) são desnecessários já que este operador tem maior precedência que a disjunção (||)
                Console.WriteLine("O ano {0} é bissexto",ano);
            else
                Console.WriteLine("O ano {0} não é bissexto",ano);
        }
    }
}
