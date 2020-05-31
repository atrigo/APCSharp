/*
 * Exercicio 6.15
 * Enunciado:   Escreva um programa que mostre e calcule a série S = 1/3−3/5+5/7−7/9+9/11 ..., sendo N o número de 
 *               termos da série informado pelo utilizador.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, n=1,i;
            float soma = 0;
            Console.Write("Quantos termos? ");
            N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                Console.Write("S={0}/{1}", n, n + 2);
                soma += (float)n / (n + 2);
                for (i = 1; i < N; i++)
                {
                    n += 2;
                    if (i % 2 == 0)
                    {
                        soma += (float)n / (n + 2);
                        Console.Write("+{0}/{1}", n, n + 2);
                    }
                    else
                    {
                        soma -= (float)n / (n + 2);
                        Console.Write("-{0}/{1}", n, n + 2);
                    }
                }
               Console.WriteLine("\nSoma={0}", soma);
            }
        }
    }
}
