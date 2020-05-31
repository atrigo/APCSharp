
/*
 * Exercicio 4.17
 * Enunciado: Altere o programa anterior por forma a que o valor da taxa de IVA seja também um valor fornecido pelo utilizador.
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
            float b,t;
            Console.Write("Introduza o preço base: "); 
            b = Convert.ToSingle(Console.ReadLine());// Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            Console.Write("Introduza a taxa de IVA: "); // Deve ser introduzido como um nº real e não em percentagem
            t = Convert.ToSingle(Console.ReadLine());// Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            Console.WriteLine("PVP={0:F2}EUR",b*(1+t)); 
        }
    }
}

