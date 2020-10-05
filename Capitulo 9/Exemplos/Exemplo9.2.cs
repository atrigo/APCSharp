
/*
 * Exemplo 9.2
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
            char[] a = { 'C', 'o', 'i', 'm', 'b', 'r', 'a' };
            char[] b = { 'C', 'o', 'i', 'm', 'b', 'r', 'a' };
            Console.WriteLine("{0}", a == b); //False
            string strA = "Coimbra";
            string strB = "Coimbra";
            Console.WriteLine("{0}", strA == strB); //True        
        }
    }
}
