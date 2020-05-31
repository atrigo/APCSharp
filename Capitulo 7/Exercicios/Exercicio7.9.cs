/*
 * Exercicio 7.9
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static bool Par(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int N,n=0,cont=0;
            Console.Write("Quantos números pares? ");
            N = Convert.ToInt32(Console.ReadLine());
            while(cont < N)
                if (Par(++n))
                {
                    Console.WriteLine(n);
                    cont++;
                }
        }
    }
}
