/*
 * Exercicio 5.6
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
            float f1, f2;
            Console.Write("Introduza a nota da 1ª frequência: ");   // Não é feita validação, ou seja, o utilizador pode 
            f1 = Convert.ToSingle(Console.ReadLine());              // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza a nota da 2ª frequência: ");   
            f2 = Convert.ToSingle(Console.ReadLine());              
            if(f1>=8 && f2>=8 && (f1+f2)/2>=9.5 ) 
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }
}
