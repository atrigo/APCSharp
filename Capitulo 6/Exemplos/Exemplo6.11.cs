/*
 * Exemplo 6.11
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
            int num, i;
            Console.Write("Insira um numero:");
            num = Convert.ToInt32(Console.ReadLine());
            bool eprimo = true;
            for (i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    eprimo = false;
                    break;
                }
            }
            if (eprimo)
                Console.WriteLine("O numero {0} e primo.", num);
            else
                Console.WriteLine("O numero {0} nao e primo.", num);
        }
    }
}
