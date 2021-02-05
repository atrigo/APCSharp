/*
 * Exercicio 6.36
 * Enunciado: Escreva um programa que apresente no ecrã todas as capicuas até 10000.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero, novo_numero;
            int digito;

            for (i = 10; i < 10000; i++)
            {
                numero = i;
                novo_numero = 0;   
                while (numero > 0)
                {
                    digito = numero % 10;
                    novo_numero = novo_numero * 10 + digito;
                    numero = numero/10;
                }
                if (i == novo_numero)
                    Console.WriteLine(i);
            }
        }
    }
}
