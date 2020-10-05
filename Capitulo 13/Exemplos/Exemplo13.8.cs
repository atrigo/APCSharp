/*
 * Exemplo 13.8
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
            long offset;
            int nextByte;
            FileStream fs = new FileStream("file7.dat", FileMode.Open, FileAccess.Read)
            while ((nextByte = fs.ReadByte()) > 0) ;
            Console.WriteLine(fs.Position);
            fs.Close();
        }
    }
}