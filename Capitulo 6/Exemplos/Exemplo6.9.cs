/*
 * Exemplo 6.9
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
            int numero, aux, digito, soma = 0;
            Console.WriteLine("Insira um numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            aux = numero;
            while (aux != 0)
            {
                digito = aux % 10;
                aux /= 10;
                soma += digito;
            }
            Console.WriteLine("A soma dos digitos do numero {0} e {1}.", numero, soma);
        }
    }
}
