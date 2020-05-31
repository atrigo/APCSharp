/*
 * Exercício 8.17
 * Livro: Aprenda a programar com C#
 * Autores: António Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/
using System;

namespace Cap8
{
    class Program
    {
        static void apresentaVetor(int[,] v)
        {
            for (int i=0; i<v.GetLength(0);i++) // Linha
            {
                for (int j=0; j<v.GetLength(1);j++) // Coluna
                    Console.Write(" {0}", v[i,j]);
                Console.WriteLine();
            }
        }

        static Array redimensionaArray(int[,] original, int[] novo) //Consultar o seguinte artigo: https://msdn.microsoft.com/en-us/library/bb348051(v=vs.110).aspx
        {
            //O novo Array deve ter o mesmo nº de dimensões do original");
            int[,] temp = (int[,])Array.CreateInstance(original.GetType().GetElementType(), novo);
            for(int i=0;i<original.GetLength(0);i++)
                for (int j=0; j<original.GetLength(1);j++)
                    temp[i,j]=original[i,j];
            return temp;
        }



        static void Main(string[] args)
        {
            int[,] V = new int[4,3]{ { 2, 1, 8 }, { 7, 2, 6 }, { 8, 9, 5 }, { 8, 2, 9 } };
            Console.WriteLine("*** Matriz original ***");
            apresentaVetor(V);
            V = (int[,]) redimensionaArray(V, new int[] { 4, 4 });
            for(int i=0;i<V.GetLength(0);i++)
                for (int j=0; j<V.GetLength(1)-1;j++)
                    V[i,V.GetLength(0)-1]+=V[i,j];
            Console.WriteLine("*** Matriz Alterada ***");
            apresentaVetor(V);
        }
    }
}
