/*
 * Exercicio 6.7
 * Enunciado:   Escreva um programa que leia uma sequência de números inteiros a partir 
 *              do teclado e apresente o máximo e o mínimo. O programa termina quando o número lido for zero.
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
            int n, max, min;
            Console.Write("Introduza um nº inteiro (zero para sair): ");
            n = Convert.ToInt32(Console.ReadLine());
            max = n;
            min = n;
            while (n != 0)
            {
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
                Console.Write("Introduza um nº inteiro (zero para sair): ");
                n = Convert.ToInt32(Console.ReadLine());
            } 
            if(max==0 && min==0) // Se max e min têm o valor zero quer dizer que o primeiro nº digitado foi zero, ou seja, a condição de saída
                Console.WriteLine("Não foi introduzido nenhum número"); 
            else
                Console.WriteLine("Máximo: {0}\nMínimo: {1}",max,min); 
        }
    }
}
