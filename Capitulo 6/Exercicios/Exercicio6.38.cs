/*
 * Exercicio 6.38
 * Enunciado: Qual é o menor múltiplo de 416 composto apenas pelos dígitos 1 e 2?
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
            long i = 1, num = 416, n, r;
            do
            {
                n = num * ++i;
                do
                {
                    r = n % 10;
                    n /= 10;
                } while (n != 0 && (r == 1 || r == 2));
            }
            while (n != 0 || r != 1 && r != 2);
            Console.WriteLine(num * i);
        }
    }
}
