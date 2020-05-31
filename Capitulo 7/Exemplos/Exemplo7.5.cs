/*
 * Exemplo 7.5
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Ola()
        {
            Console.WriteLine("Ola");
        }
        static void BomDia()
        {
            Console.WriteLine("Bom dia!");
        }
        static void ComoEsta()
        {
            Console.WriteLine("Como esta?");
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("Saudacoes em portugues:");
                Console.WriteLine("1 - Ola.");
                Console.WriteLine("2 - Bom dia");
                Console.WriteLine("3 - Como esta");
                Console.WriteLine("0 - Sair");
                cki = Console.ReadKey();
                Console.Clear();
                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                        Ola();
                        break;
                    case ConsoleKey.D2:
                        BomDia();
                        break;
                    case ConsoleKey.D3:
                        ComoEsta();
                        break;
                }
                if (cki.Key != ConsoleKey.D0)
                {
                    Console.WriteLine("Prima enter para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (cki.Key != ConsoleKey.D0);
        }
    }
}
