/*
 * Exemplo 13.9
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
            // alphabet.txt contem "abcdefghijklmnopqrstuvwxyz"
            FileStream fs = new FileStream(@"c:\alfabeto.txt", FileMode.Open,
            FileAccess.Read)
            for (offset = 1; offset <= fs.Length; offset++)
            {
                fs.Seek(-offset, SeekOrigin.End);
                Console.Write(Convert.ToChar(fs.ReadByte()));
            }
            fs.Close();
        }
    }
}