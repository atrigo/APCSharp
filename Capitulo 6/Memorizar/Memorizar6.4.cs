/*
 * Memorizar 6.4
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
            int numero, aux, digito, novoNumero = 0;
            Console.WriteLine("Insira um numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            aux = numero;
            while (aux != 0)
            {
                digito = aux % 10;
                novoNumero = novoNumero * 10 + digito;
                aux /= 10;
            }
            if (numero == novoNumero)
                Console.WriteLine("O numero {0} e uma capicua.", numero);
            else
                Console.WriteLine("O numero {0} nao e uma capicua.", numero);
        }
    }
}
