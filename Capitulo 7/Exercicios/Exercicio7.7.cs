/*
 * Exercicio 7.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static double Valida()
        {
            double nota;
            do
            {
                Console.Write("Introduza a nota (0 a 20): ");
                nota = Convert.ToDouble(Console.ReadLine());
            } while (nota < 0 || nota > 20);
            return nota;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Aluno {0}: {1}", i, Valida());
        }
    }
}
