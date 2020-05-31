/*
 * Exercicio 6.37
 * Enunciado: Qual é o menor múltiplo de 182 composto apenas pelo dígito 4?
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
            long i = 1, num = 182, n, r;
            do
            {
                n = num * ++i;
                do
                {
                    r = n % 10;
                    n /= 10;
                } while (n != 0 && (r == 4));
            }
            while (n != 0 || r != 4);
            Console.WriteLine(num * i);
        }
    }
}
