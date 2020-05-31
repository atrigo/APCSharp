/*
 * Exercicio 5.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 == 5? resultado: {0}", 4 == 5);
            Console.WriteLine("4 != 6? resultado: {0}", 4 != 6);
            Console.WriteLine("4 > 5? resultado: {0}", 4 > 5);
            Console.WriteLine("true == false? resultado: {0}", true == false);
            Console.WriteLine("'a' == 'a'? resultado: {0}", 'a' == 'a');
            Console.WriteLine("'a' == 'b'? resultado: {0}", 'a' == 'b');
            Console.WriteLine("2 < 3 E 3 > 4? resultado: {0}", 2 < 3 && 3 > 4);
            Console.WriteLine("2 < 3 OU 3 > 4? resultado: {0}", 2 < 3 || 3 > 4);
            Console.WriteLine("NAO(2 < 3 || 3 > 4)? resultado: {0}", !(2 < 3 || 3 > 4));
        }
    }
}
