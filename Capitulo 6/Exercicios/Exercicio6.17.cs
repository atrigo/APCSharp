/*
 * Exercicio 6.17
 * Enunciado:   Altere o programa de cálculo dos números primos, apresentando, caso o número não seja primo, 
 *              os números pelos quais ele é divisível.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, n, i;
            bool primo;
            Console.Write("Introduza o valor de N:");
            N = Convert.ToInt32(Console.ReadLine());
            for (n = 2; n <= N; n++)
            {
                primo = true;
                for (i = 2; i <n; i++)
                   if (n % i == 0)
                    {
                        Console.Write(" {0}",i);
                        primo = false;
                    }
                if(primo)
                    Console.WriteLine(" {0} é primo",n);
                else
                    Console.WriteLine(" (é/são) divisor(es) de {0}, logo não é primo",n);
            }
        }
    }
}
