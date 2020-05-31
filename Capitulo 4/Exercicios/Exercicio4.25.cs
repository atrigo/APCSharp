/*
 * Exercicio 4.25
 * Enunciado:   Escreva um programa que calcule a distância Euclidiana entre dois pontos P(x1,y1) e P(x2,y2). 
 *              distancia = RAIZQUADRADA((x1-x2)^2+(y1-y2)^2)
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
            int x1,x2,y1,y2;
            double d;
            Console.Write("Introduza o valor de x1: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o valor de y1: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o valor de x2: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o valor de y2: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            y2 = Convert.ToInt32(Console.ReadLine());
            d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("Distância Euclidiana: {0:F2}",d); 
        }
    }
}
