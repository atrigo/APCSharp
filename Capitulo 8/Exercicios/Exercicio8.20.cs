/*
 * Exercício 8.20
 * Livro: Aprenda a programar com C#
 * Autores: António Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/
using System;

namespace Cap8
{
    class Program
    {
        static void apresentaMatriz(int[,] v)
        {
            for (int i=0; i<v.GetLength(0);i++) // Linha
            {
                for (int j=0; j<v.GetLength(1);j++) // Coluna
                    Console.Write("{0,7}", v[i,j]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] V = new int[10,3];
            int cont = 0;
            for (int i = 0; i < V.GetLength(0); i++)
            {
                do
                {
                    Console.Write("Introduza um número inteiro entre 1 e 100: ");
                    V[i, 0] = Convert.ToInt32(Console.ReadLine());
                } while (V[i, 0] < 1 || V[i, 0] > 100);
                V[i, 1] = V[i, 0] * V[i, 0];
                V[i, 2] = V[i, 1] * V[i, 0];
            }
            apresentaMatriz(V);
            foreach (int n in V)
                if (n > 1000)
                    cont++;
            Console.WriteLine("Existem {0} valores superiores a 1000",cont);
        }
    }
}
