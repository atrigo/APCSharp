/*
 * Exemplo 5.15
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
            string mes;
            Console.Write("Insira um mes:");
            mes = Console.ReadLine();
            switch (mes)
            {
                case "janeiro":
                case "marco":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine("O mes tem 31 dias");
                    break;
                case "fevereiro":
                    Console.WriteLine("O mes tem 28 ou 29 dias");
                    break;
                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    Console.WriteLine("O mes tem 30 dias");
                    break;
                default:
                    Console.WriteLine("Mes invalido");
                    break;
            }
        }
    }
}
