/*
 * Exemplo 13.10
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
            string texto = "este texto vai ser atualizado para trocar todos os 'a' por 'z'";
            Console.WriteLine(texto);
            StreamWriter sw = new StreamWriter("texto.txt");
            sw.Write(texto);
            sw.Close();
            FileStream fs = new FileStream("texto.txt", FileMode.Open,
            FileAccess.ReadWrite);
            int byteLido;
            while ((byteLido = fs.ReadByte()) > 0)
            {
                char car = (char)byteLido;
                if (car == 'a')
                {
                    fs.Seek(-1, SeekOrigin.Current);
                    fs.WriteByte((byte)'z');
                }
            }
            fs.Close();
            StreamReader sr = new StreamReader("texto.txt");
            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }
    }
}