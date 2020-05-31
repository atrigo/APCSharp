/*
 * Exercicio 8.16
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {
        static void apresentaVetor(double[] v)
        {
            foreach (double n in v)
                Console.Write(" {0}", n);
            Console.WriteLine();
        }

        static void ordenaVector(double[] v)
        {
            int L = v.Length;
            double temp;
            bool troca; // a utilização desta variável evita que o programa continue a fazer iterações quando o vetor já está ordenado tornando-o assim amis eficiente
            do
            {
                troca = false;
                --L;
                for (int i = 0; i < L; i++)
                    if (v[i] < v[i + 1])
                    {
                        temp = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = temp;
                        troca = true;
                    }
            } while (troca);
        }

        static void Main(string[] args)
        {
            double[] V = { 6.35, 16.124, 8.45, 9.654, 14.32, 3.55, 2.21, 4.24, 6.247, 4.01 };
            Console.WriteLine("*** Vetor original ***");
            apresentaVetor(V);
            ordenaVector(V);
            Console.WriteLine("*** Vetor ordenado ***");
            apresentaVetor(V);
        }
    }
}
