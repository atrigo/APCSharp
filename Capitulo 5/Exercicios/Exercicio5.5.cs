/*
 * Exercicio 5.5
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

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
            if(a>b)     // Note a importância da indentação para a correta leitura do código
                if(a>c)
                    Console.WriteLine("Maior valor: {0}",a);
                else
                    Console.WriteLine("Maior valor: {0}",c);
            else
                if(b>c)
                    Console.WriteLine("Maior valor: {0}",b);
                else
                    Console.WriteLine("Maior valor: {0}",c);
        }
    }
}
