/*
 * Exercicio 5.14
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
            char c;
            Console.Write("Introduza uma carácter: ");  
            c = Convert.ToChar(Console.ReadLine());     
            if(c>='a'&&c<='z'||c>='A'&&c<='Z')
                if(c=='a'||c=='A'||c=='e'||c=='E'||c=='i'||c=='I'||c=='o'||c=='O'||c=='u'||c=='U')
                    Console.WriteLine("Vogal");
                else
                    Console.WriteLine("Consoante");
            else
                Console.WriteLine("Outro");
        }
    }
}
