/*
 * Exercicio 10.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, N=4,soma=0;
            bool continua;
            for(int i=0; i<N; i++)
            {
                do
                {
                    try
                    {
                        Console.Write("Introduza um número inteiro: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        continua = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continua = true;
                    }
                } while (continua);
                soma += num;
            }
            Console.WriteLine("Média: {0}",soma/(float)N);
        }
    }
}
