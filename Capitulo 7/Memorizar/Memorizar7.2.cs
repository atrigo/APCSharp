/*
 * Memorizar 7.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void TrocaValor(int x, int y)
        {
            int aux;
            aux = x;
            x = y;
            y = aux;
        }
        static void TrocaReferencia(ref int x, ref int y)
        {
            int aux;
            aux = x;
            x = y;
            y = aux;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            Console.WriteLine("O valor inicial das variaveis e a:{0} e b:{1}", a, b);
            TrocaValor(a, b);
            Console.WriteLine("O valor das variaveis depois de chamada a funcao TrocaValor e a:{0} e b:{1}", a, b);
            TrocaReferencia(ref a, ref b);
            Console.WriteLine("O valor das variaveis depois de chamada a funcao TrocaReferencia e a:{0} e b:{1}", a, b);
        }
    }
}
