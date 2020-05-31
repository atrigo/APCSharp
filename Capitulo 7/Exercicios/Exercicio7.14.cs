/*
 * Exercicio 7.14
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static int custosExp(int n)
        {
            int soma;
            if (n == 0)
                return 0;
            else
            {
                soma = 5;
                for (int i = 1; i < n; i++)
                    soma++;
            }
            return soma;
        }

        static void Main(string[] args)
        {
            int N;
            Console.Write("Quantos itens tem a encomenda? ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Os custos de expedição serão: {0}", custosExp(N));
        }
    }
}
