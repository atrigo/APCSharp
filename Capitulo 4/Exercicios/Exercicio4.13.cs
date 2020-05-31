
/*
 * Exercicio 4.13
 * Enunciado: Escreva um programa que calcule a hipotenusa de um triângulo retângulo (utilizar o método Math.Sqrt).
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


//Versão 1

using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1,c2,h;
            Console.Write("Introduza o valor do primeiro cateto: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            c1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza o valor do segundo cateto: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            c2 = Convert.ToSingle(Console.ReadLine());
            h = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));
            Console.WriteLine("Hipotenusa:{0}",h); 
        }
    }
}

//Versão 2

using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1,c2;
            Console.Write("Introduza o valor do primeiro cateto: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            c1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduza o valor do segundo cateto: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            c2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hipotenusa:{0}",Math.Sqrt(c1*c1 + c2*c2)); 
        }
    }
}

