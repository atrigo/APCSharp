/*
 * Exercicio 6.23
 * Enunciado:   Supondo que a população do país A é de 80000 habitantes com uma taxa anual de crescimento de 3%
 *              e que a população do país B é 200000 habitantes com uma taxa de crescimento de 1.5%. Escreva um 
 *              programa que calcule e escreva o número de anos necessários para que a população do país A 
 *              ultrapasse ou igual a população do país B, mantidas as taxas de crescimento.
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
            double A=80000, tcA=0.03,B=200000,tcB=0.015,a=0;
            while (A < B)
            {
                A *= (1 + tcA);
                B *= (1 + tcB);
                a++;
            }
            Console.WriteLine("A população do país A igualará ou ultrapassará a população do país B em {0} anos",a);
        }
    }
}
