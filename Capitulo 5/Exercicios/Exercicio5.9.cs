/*
 * Exercicio 5.9
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
            int p,s,t;
            Console.Write("Introduza o primeiro valor: ");  // Não é feita validação, ou seja, o utilizador pode introduzir 
            p = Convert.ToInt32(Console.ReadLine());        // caracteres inválidos e como tal gerar excepções (ERROS)
            Console.Write("Introduza o segundo valor: ");  
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o terceiro valor: ");  
            t = Convert.ToInt32(Console.ReadLine());
            if (p < s)     // Note a importância da indentação para a correta leitura do código
                if (p < t)
                    if (s < t)
                        Console.WriteLine("{0} {1} {2}", p, s, t);
                    else
                        Console.WriteLine("{0} {1} {2}", p, t, s);
                else
                    Console.WriteLine("{0} {1} {2}", t, p, s);
            else
                if (s < t)
                    if (p < t)
                        Console.WriteLine("{0} {1} {2}", s, p, t);
                    else
                        Console.WriteLine("{0} {1} {2}", s, t, p);
                else
                    Console.WriteLine("{0} {1} {2}", t, s, p);
        }
    }
}
