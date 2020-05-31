
/*
 * Exercicio 4.20
 * Enunciado:   Escreva um programa que calcule a média final a uma disciplina, 
 *              arredondada a 0 casas decimais, sabendo que essa disciplina possui dois testes de avaliação.
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
            float p,s;
            Console.Write("Qual é a nota da 1ª frequência: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            p = Convert.ToSingle(Console.ReadLine());
            Console.Write("Qual é a nota da 2ª frequência: "); 
            s = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nota final {0:F0}",(p+s)/2); 
        }
    }
}
