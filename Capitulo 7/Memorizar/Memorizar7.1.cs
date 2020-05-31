/*
 * Memroizar 7.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static float Area(float c, float l)
        {
            return c * l;
        }
        static void Main(string[] args)
        {
            float comp, larg;
            Console.WriteLine("Introduza os dados do retangulo: ");
            Console.Write("Comprimento: ");
            comp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Largura: ");
            larg = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("A area do retangulo e: {0}", Area(comp, larg));
        }
    }
}
