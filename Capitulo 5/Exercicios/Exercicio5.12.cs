/*
 * Exercicio 5.12
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
            int a;
            Console.Write("Introduza um número de 0 a 9: ");  // Não é feita validação, ou seja, o utilizador pode 
            a = Convert.ToInt32(Console.ReadLine());       // introduzir caracteres inválidos e gerar excepções (ERROS)
            switch (a)
            {
                case 0: Console.WriteLine("Zero");break;
                case 1: Console.WriteLine("Um");break;
                case 2: Console.WriteLine("Dois");break;
                case 3: Console.WriteLine("Três");break;
                case 4: Console.WriteLine("Quatro");break;
                case 5: Console.WriteLine("Cinco");break;
                case 6: Console.WriteLine("Seis");break;
                case 7: Console.WriteLine("Sete");break;
                case 8: Console.WriteLine("Oito");break;
                case 9: Console.WriteLine("Nove");break;
                default:Console.WriteLine("Número inválido");break;
            }
        }
    }
}

