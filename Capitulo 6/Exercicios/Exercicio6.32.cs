/*
 * Exercicio 6.32
 * Enunciado: Escreva um programa que converta a numeração Árabe em Romana.
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
            int peso, linha, coluna, num;
            string[,] romano = new string[,] {{"I","II","III","IV","V","VI","VII","VIII","IX"},
                                             {"X","XX","XXX","XL","L","LX","LXX","LXXX","XC"},
                                             {"C","CC","CCC","CD","D","DC","DCC","DCCC","CM"},
                                             {"M","MM","MMM","","","","","",""}};
            string result = "";
            Console.Write("Introduza um número árabe até 3999: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (peso = 1000, linha = 3; peso >= 1; peso = peso / 10, linha--)
            {
                coluna = num / peso;
                if (coluna >= 1)
                {
                    num = num % peso;
                    result += romano[linha, coluna - 1];
                }
            }
            Console.WriteLine("Romano: {0}", result);
        }
    }
}
