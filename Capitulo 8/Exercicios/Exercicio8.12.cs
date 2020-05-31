/*
 * Exercicio 8.12
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap8
{
    class Program
    {

        static void freqAbs(int[] N)
        {
            int i,j,k = 0; 
            int[,] F = new int[N.Length,2]; // Neste vetor de duas colunas, o valor aparece na 1ª e a frequência na 2ª
            for(i=0; i<N.Length; i++)
            {
                for (j = 0; j < k; j++)
                    if (N[i] == F[j, 0]) // Se o valor foi encontrado incrementa-se o contador para esse valor ( 2ª coluna)
                    {
                        F[j, 1]++;
                        break;
                    }
                if(j==k) // Se j==k quer dizer que o ciclo chegou ao fim sem encontrar o valor e como tal deve ser acrescentado ao vetor F
                    {
                        F[k, 0]=N[i];
                        F[k++, 1]++;
                    }
            }
            Console.WriteLine("GRÁFICO FREQ. ABS.\n___________________");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0}| ", F[i, 0]);
                for (j = 0; j < F[i, 1]; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
            Console.WriteLine("___________________");
        }

        static void Main(string[] args)
        {
            int[] B= { 2, 1, 8, 7, 2, 6, 8, 6, 2, 8, 2, 9};
            freqAbs(B);
        }
    }
}
