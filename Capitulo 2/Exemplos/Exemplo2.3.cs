
/*
 * Exemplo 2.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.Write("Insira um numero :");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira outro numero :");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
                Console.WriteLine("O maior numero e: {0} ", numero1);
            else
                Console.WriteLine("O maior numero e: {0} ", numero2);
        }
    }
}
