/*
 * Exercicio 7.12
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static int numMax(int n)
        {
            int contador = 0, num, max;
            Console.Write("Inntroduza um nº inteiro: ");
            max = Convert.ToInt32(Console.ReadLine());
            contador++;
            for (int i = 1; i < n; i++)
            {
                Console.Write("Inntroduza um nº inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == max)
                    contador++;
                else
                    if (num > max)
                {
                    contador = 1;
                    max = num;
                }
            }
            return contador;
        }

        static void Main(string[] args)
        {
            int N;
            Console.Write("Quantos números pretende introduzir (>0): ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O valor máximo ocorreu {0} vezes", numMax(N));
        }
    }
}
