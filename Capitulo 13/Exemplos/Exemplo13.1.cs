/*
 * Exemplo 13.1
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
            try
            {
                StreamReader sr = new StreamReader(``file.txt'');
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Nao foi possivel ler o ficheiro:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}