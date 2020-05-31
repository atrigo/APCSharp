/*
 * Exemplo 7.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static bool ValidaHoras(int horas)
        {
            if (horas >= 0 && horas <= 23)
                return true;
            else
                return false;
        }
        static bool ValidaMinutos(int minutos)
        {
            if (minutos >= 0 && minutos <= 59)
                return true;
            else
                return false;
        }

        static void Main()
        {
            Console.WriteLine("Que horas sao?");
            Console.Write("Horas: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutos: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (ValidaHoras(h) && ValidaMinutos(m))
            {
                Console.WriteLine("Sao {0}:{1}.", h, m);
            }
            else
            {
                Console.WriteLine("Hora incorreta!");
            }
        }
    }
}
