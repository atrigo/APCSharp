/*
 * Exercicio 5.11
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

//Versao 1
using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Introduza o primeiro valor: ");  // Não é feita validação, ou seja, o utilizador pode 
            a = Convert.ToInt32(Console.ReadLine());       // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o segundo valor: ");  
            b = Convert.ToInt32(Console.ReadLine());       
            Console.Write("Introduza o terceiro valor: ");  
            c = Convert.ToInt32(Console.ReadLine());      
            if(a<b+c && b<a+c && c<a+b)     // É um triângulo?
                if(a==b && a== c)       // Qual é o tipo de triângulo?
                    Console.WriteLine("É um triângulo equilátero");
                else
                    if(a==b || a== c || b==c)          
                        Console.WriteLine("É um triângulo isósceles");
                    else
                        Console.WriteLine("É um triângulo escaleno");
            else
                Console.WriteLine("Não é um triângulo");
        }
    }
}

//Versao 2

using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Introduza o primeiro valor: ");  // Não é feita validação, ou seja, o utilizador pode 
            a = Convert.ToInt32(Console.ReadLine());       // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o segundo valor: ");  
            b = Convert.ToInt32(Console.ReadLine());       
            Console.Write("Introduza o terceiro valor: ");  
            c = Convert.ToInt32(Console.ReadLine());      
            if(a<b+c && b<a+c && c<a+b)     // É um triângulo?
                if(a==b )       // Qual é o tipo de triângulo?
                    if(a==c)
                        Console.WriteLine("É um triângulo equilátero");
                    else
                        Console.WriteLine("É um triângulo isósceles");
                else
                    if(a== c || b==c)          
                        Console.WriteLine("É um triângulo isósceles");
                    else
                        Console.WriteLine("É um triângulo escaleno");
            else
                Console.WriteLine("Não é um triângulo");
        }
    }
}
