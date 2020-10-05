/*
 * Exemplo 13.3
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
                using (FileStream fs = new FileStream("file.txt",
                FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                }
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