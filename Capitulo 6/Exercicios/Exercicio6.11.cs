/*
 * Exercicio 6.11
 * Enunciado:  Altere o jogo do adivinho apresentado anteriormente para contar o número de tentativas de acerto.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

/*
O Exercício 6.11 deveria ter sido precedido pelo seguinte exercício:
Escreva um programa que, por tentativas, adivinha um numero que é gerado
pelo computador.Em cada tentativa deve-lhe ser indicado se o numero
que introduziu é maior ou menor que o valor gerado. O programa termina
quando acertar.
Ver solucao do exemplo 6.10.
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n, num, min = 0, max = 100, t=0;
            Random rnd = new Random(); //Gerador de números aleatórios
            n = rnd.Next(0, 100);//Gera números entre 0 e 100
            Console.WriteLine("O nº gerado é: {0}", n);
            do
            {
                num = min + (max - min) / 2; // Em cada iteração o intervalo é dividido ao meio
                if (num > n)
                    max = num;
                else
                    min = num;
                t++;   // Contador de tentativas
            } while (n != num);
            Console.WriteLine("O nº é: {0}, foi obtido em {1} tentativas", n,t);
        }
    }
}

