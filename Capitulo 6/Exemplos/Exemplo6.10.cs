/*
 * Exemplo 6.10
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
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 101);
            int numero;
            do
            {
                Console.Write("Qual o numero secreto?");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < numeroSecreto)
                    Console.WriteLine("Insira um numero maior!");
                if (numero > numeroSecreto)
                    Console.WriteLine("Insira um numero menor!");
            } while (numero != numeroSecreto);
            Console.WriteLine("Parabens! Acertou no numero secreto: {0}", numero);
        }
    }
}
