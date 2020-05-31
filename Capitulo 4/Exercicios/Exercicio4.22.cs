/*
 * Exercicio 4.22
 * Enunciado:   Num determinado stand de automóveis, os vendedores ganham um salário mensal base X, 
 *              uma comissão de Y euros por cada automóvel que vendem e uma percentagem P sobre o valor 
 *              das vendas V que efetuarem. Escreva um programa que calcule e imprima o salário que um 
 *              vendedor vai auferir este mês.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            double X,Y,P,V,q;
            Console.Write("Qual é o salário base: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            X = Convert.ToSingle(Console.ReadLine());
            Console.Write("Qual é a comissão por automóvel: "); 
            Y = Convert.ToSingle(Console.ReadLine());
            Console.Write("Quantos automóveis vendeu: "); 
            q = Convert.ToSingle(Console.ReadLine());
            Console.Write("Qual é a percentagem sobre o valor das vendas: "); //Introduza um valor decimal
            P = Convert.ToSingle(Console.ReadLine());
            Console.Write("Qual é o valor das vendas: "); 
            V = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Salário mensal: {0:F2} ",X+q*Y+P*V); 
        }
    }
}
