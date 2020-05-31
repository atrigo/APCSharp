/*
 * Exemplo 5.12
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
            if (dia == 0)
                Console.WriteLine("Domingo.");
            else if (dia == 1)
                Console.WriteLine("Segunda-feira");
            else if (dia == 2)
                Console.WriteLine("Terca-feira");
            else if (dia == 3)
                Console.WriteLine("Quarta-feira");
            else if (dia == 4)
                Console.WriteLine("Quinta-feira");
            else if (dia == 5)
                Console.WriteLine("Sexta-feira");
            else if (dia == 6)
                Console.WriteLine("Sabado");
            else
                Console.WriteLine("Dia invalido!");
        }
    }
}
