/*
 * Exemplo 7.4
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
            int op = 0;
            do
            {
                Console.WriteLine("Saudacoes em portugues:");
                Console.WriteLine("1 - Ola.");
                Console.WriteLine("2 - Bom dia");
                Console.WriteLine("3 - Como esta");
                Console.WriteLine("0 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Ola();
                        break;
                    case 2:
                        BomDia();
                        break;
                    case 3:
                        ComoEsta();
                        break;
                }
                if (op != 0)
                {
                    Console.WriteLine("Prima enter para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (op != 0);
        }
    }
}
