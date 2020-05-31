/*
 * Exercicio 5.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.Write("Introduza a nota: ");        // Não é feita validação, ou seja, o utilizador pode introduzir valores fora 
            nota = Convert.ToInt32(Console.ReadLine());// da gama permitida (0:20) ou caracteres inválidos e como tal gerar excepções (ERROS)
            Console.WriteLine(nota>=10 ? "Parabéns" : "Faça um novo exame");
        }
    }
}
