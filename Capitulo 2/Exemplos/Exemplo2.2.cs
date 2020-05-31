
/*
 * Exemplo 2.2
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
            int numero1, numero2, soma;
            Console.Write("Insira um numero :");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira outro numero :");
            numero2 = Convert.ToInt32(Console.ReadLine());
            soma = numero1 + numero2;
            Console.WriteLine("A soma do numero {0} com o numero {1} e: {2}", numero1, numero2, soma);
        }
    }
}
