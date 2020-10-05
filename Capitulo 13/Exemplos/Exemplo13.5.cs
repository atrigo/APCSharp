/*
 * Exemplo 13.5
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
            string[] nomes = new string[] { "Antonio Trigo", "Jorge Henriques" };
            using (FileStream fs = new FileStream("nomes.txt",
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (string s in nomes)
                        sw.WriteLine(s);
                }
            }
            //Opcional: o codigo abaixo serve para ler o ficheiro 
            string linha = "";
            using (StreamReader sr = new StreamReader("nomes.txt"))
            {
                while ((linha = sr.ReadLine()) != null)
                    Console.WriteLine(linha);
            }
            Console.ReadKey();
        }
    }
}