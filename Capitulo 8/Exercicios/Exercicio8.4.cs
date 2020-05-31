/*
 * Exercicio 8.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {
        static int Pesquisa(int[] v, int p)
        {
            for (int i=0;i<v.Length;i++)
                if (v[i] == p)
                    return i;
            return -1;
        }

        static void Main(string[] args)
        {
            int[] V= { 2, 6, 8, 9, 3, 4, 6, 4, 4, 6 };
            Console.Write("Qual número pretende pesquisar? ");
            int N = Convert.ToInt32(Console.ReadLine());
            if(Pesquisa(V,N)==-1)
                Console.WriteLine("O número {0} não foi encontrado",N);
            else
                Console.WriteLine("O número {0} foi encontrado pela primeira vez no índice {1} ",N,Pesquisa(V,N));
        }
    }
}
