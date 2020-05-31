/*
 * Exercicio 8.3
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
            int cont = 0;
            foreach (int a in v)
                if (a == p)
                    cont++;
            if(cont==0)
                return -1;
            else
                return cont;
        }

        static void Main(string[] args)
        {
            int[] V= { 2, 6, 8, 9, 3, 4, 6, 4, 4, 6 };
            Console.Write("Qual número pretende pesquisar? ");
            int N = Convert.ToInt32(Console.ReadLine());
            if(Pesquisa(V,N)==-1)
                Console.WriteLine("O número {0} não foi encontrado",N);
            else
                Console.WriteLine("O número {0} foi encontrado {1} vezes",N,Pesquisa(V,N));
        }
    }
}
