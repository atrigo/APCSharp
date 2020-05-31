/*
 * Exemplo 3.3
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
            double raio;
            const double pi = 3.14;
            Console.WriteLine("Insira um valor para o raio : ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O valor da area do circulo de raio {0} e: {1}", raio , 2 * pi * raio * raio );
            Console.WriteLine("O valor da area do circulo de raio {0} e: {1}", raio , 2* Math .PI* raio * raio );
        }
    }
}
