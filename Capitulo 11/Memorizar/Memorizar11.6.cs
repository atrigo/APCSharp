/*
 * Memorizar 11.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(2022, 11, 22, 10, 30, 32);
            Console.WriteLine(data1);
            DateTime data2 = new DateTime();
            Console.WriteLine(data2);
            DateTime data3 = DateTime.Now;
            DateTime data4 = DateTime.UtcNow; //Coordinated Universal Time (UTC)
            DateTime data5 = DateTime.Today;
            Console.WriteLine(data3);
            Console.WriteLine(data4);
            Console.WriteLine(data5);
            DateTime data6 = DateTime.Parse("22/11/2022 10:30:32");
            Console.WriteLine(data6);
        }
    }
}