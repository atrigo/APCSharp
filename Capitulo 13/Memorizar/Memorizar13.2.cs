/*
 * Exemplo 13.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream F = new FileStream("test.dat",
            FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                for (int i = 10; i < 20; i++)
                {
                    F.WriteByte((byte)i);
                }
                F.Position = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(F.ReadByte() + " ");
                }
            }
            Console.ReadKey();
        }
    }
}