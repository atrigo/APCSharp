/*
 * Exercicio 7.15
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static int pot2(int e)
        {
            if (e == 0)
                return 1;
            else
                return 2 * pot2(e - 1);
        }

        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
                Console.WriteLine("2^{0}={1}", i,pot2(i));
        }
    }
}
