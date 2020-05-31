/*
 * Exercicio 8.5
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
            double[] V= {  6.35, 2.21, 8.45, 9.654, 3.55, 4.24, 6.247, 16.124, 4.01, 14.32 };
            int max = 0, min=0; // Começamos por assumir que o maior e o menor estão no índice 0
            for (int i = 1; i < V.Length; i++)// O ciclo começa em 1 devido ao comentário anterior
            {
                if (V[i] < V[min])
                    min = i;
                if (V[i] > V[max])
                    max = i;
            }
            Console.WriteLine("O mínimo está no índice {0} e tem o valor {1}",min,V[min]);
            Console.WriteLine("O máximo está no índice {0} e tem o valor {1}",max,V[max]);
        }
    }
}
