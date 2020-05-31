/*
 * Exemplo 5.13
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
            Console.Write("Insira um valor para o dia da semana:");
            int dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 0:
                    Console.WriteLine("Domingo.");
                    break;
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terca-feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia invalido!");
                    break;
            }
        }
    }
}
