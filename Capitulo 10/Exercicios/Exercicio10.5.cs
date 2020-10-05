/*
 * Exercicio 10.5
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] V = { 2, 6, 8, 9, 3, 9, 6, 4, 9, 6 };
            int i;
            bool continua;
            do
            {
                try
                {
                    Console.Write("Introduza o índice que pretende ver: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.Write("V[{0}]={1}",i,V[i]);
                    continua = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continua = true;
                }
            } while (continua);
        }
    }
}
