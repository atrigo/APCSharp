/*
 * Exercicio 6.6
 * Enunciado:   Escreva um programa que peça dois números, base e expoente, calcule e mostre o 
                primeiro número elevado ao segundo número. Não utilize o método \textit{Pow(,)} da linguagem C\#
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

//Versao 1
using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) //o expoente deve ser zero ou um inteiro positivo 
        {
            int b, e, i, pot=1; // o elemento neutro da multiplicação é 1
            Console.Write("Introduza o valor da base: ");     // Não é feita validação, ou seja, o utilizador pode  introduzir 
            b = Convert.ToInt32(Console.ReadLine());            //valores incorrectos ou caracteres inválidos e  como tal gerar excepções (ERROS)
            Console.Write("Introduza o valor do expoente: ");
            e = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < e; i++)
                pot *= b; // ou pot= pot*b;
            Console.Write("{0}^{1}={2}\n",b,e,pot); 
        }
    }
}

//Versao 2
using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) //a base é real e o expoente pode ser qualquer inteiro
        {
            int e, i; // o elemento neutro da multiplicação é 1
            float b, pot=1; 
            Console.Write("Introduza o valor da base: ");     // Não é feita validação, ou seja, o utilizador pode  introduzir 
            b = Convert.ToSingle(Console.ReadLine());            //valores incorrectos ou caracteres inválidos e  como tal gerar excepções (ERROS)
            Console.Write("Introduza o valor do expoente: ");
            e = Convert.ToInt32(Console.ReadLine());
            if(e>=0) //avalia se o expoente é positivo ou negativo
                for (i = 0; i < e; i++) // expoente positivo
                    pot *= b; // ou pot= pot*b;
            else
            {
                for (i = 0; i < -e; i++) // expoente negativo --> troca o sinal do expoente
                    pot *= b; 
                pot = 1 / pot; // inverte pot
            }
            Console.Write("{0}^{1}={2:F3}\n",b,e,pot); 
        }
    }
}
