/*
 * Exemplo 9.10
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("De caderno fechado nao sai, ");
            sb.Replace("caderno", "livro");
            sb.Insert(sb.ToString().IndexOf(","), " letrado");
            sb.Replace(",", ".");
            Console.WriteLine(sb);
        }
    }
}
