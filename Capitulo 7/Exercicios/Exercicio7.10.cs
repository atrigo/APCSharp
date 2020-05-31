/*
 * Exercicio 7.10
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static bool Primo(uint n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            uint N, contador = 0, num = 0;
            Console.Write("Quantos números primos: ");
            N = Convert.ToUInt32(Console.ReadLine());
            do
            {
                if (Primo(++num))
                {
                    contador++;
                    Console.WriteLine(num);
                }
            } while (contador < N);
        }
    }
}
