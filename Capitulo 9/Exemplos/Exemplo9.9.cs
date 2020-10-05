/*
 * Exemplo 9.9
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
            Console.Write("Insira uma hora no formato HH:mm:ss: ");
            string hora = Console.ReadLine();
            string[] argTempo = hora.Split(':');
            int horas = Convert.ToInt32(argTempo[0]);
            int minutos = Convert.ToInt32(argTempo[1]);
            int segundos = Convert.ToInt32(argTempo[2]);
            Console.WriteLine("Ja passaram {0} segundos desde o inicio do dia.", horas * 60 * 60 + minutos * 60 + segundos);
        }
    }
}
