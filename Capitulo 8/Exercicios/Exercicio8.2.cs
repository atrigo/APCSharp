/*
 * Exercicio 8.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] v=new float[100];
            float soma = 0;
            Console.Write("Quantos números vai introduzir? ");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<N;i++)
            {
                Console.Write("Introduza um número real: "); // Não esquecer que numa consola em português o separador decimal é a virgula
                v[i] = Convert.ToSingle(Console.ReadLine());
                soma += v[i];
            }
            Console.WriteLine("Média: {0} ",soma/N);
        }
    }
}
