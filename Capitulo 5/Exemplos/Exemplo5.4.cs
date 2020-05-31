/*
 * Exemplo 5.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, maior;
            Console.Write("Insira um numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira outro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Os numeros sao iguais.");
        }
    }
}
