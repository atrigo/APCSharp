/*
 * Exercicio 7.13
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static int dado()
        {
            return rnd.Next(1, 7);
        }
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int N, v, contador = 0;
            Console.Write("Quantos lançamentos do dado: ");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if ((v = dado()) == 6)
                    contador++;
                Console.WriteLine(v);
            }
            Console.WriteLine("O número 6 ocorreu {0} vezes", contador);
        }
    }
}
