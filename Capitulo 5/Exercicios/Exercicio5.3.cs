/*
 * Exercicio 5.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

// Versao 1
using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Introduza um número inteiro: "); // Não é feita validação, ou seja, o utilizador pode introduzir um nº real ou caracteres inválidos
            i = Convert.ToInt32(Console.ReadLine()); 
            if (i>0 && i%2==0)   // a segunda parte da expressão (i%2==0) só é avaliada se da primeira resultar o valor true 
                Console.WriteLine("O número inteiro {0} é positivo e par",i); 
            else
                Console.WriteLine("O número inteiro {0} não é positivo e par",i); 
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
            int i;
            Console.Write("Introduza um número inteiro: "); // Não é feita validação, ou seja, o utilizador pode introduzir um nº real ou caracteres inválidos
            i = Convert.ToInt32(Console.ReadLine()); 
            if (i>0 )    // Esta solução, após determinar se é positivo, distingue se é ou não par
                if (i%2==0)   // Poderiam ter-se utilizado apenas dois if mas o Português não seria tão correto (ver versao 3)
                    Console.WriteLine("O número inteiro {0} é positivo e par",i); 
                else
                    Console.WriteLine("O número inteiro {0} é positivo mas não é par",i);
            else
                if (i%2==0)   
                    Console.WriteLine("O número inteiro {0} não é positivo mas é par",i); 
                else
                    Console.WriteLine("O número inteiro {0} não é positivo nem par",i);
        }
    }
}

//Versao 3
using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Introduza um número inteiro: "); // Não é feita validação, ou seja, o utilizador pode introduzir um nº real ou caracteres inválidos
            i = Convert.ToInt32(Console.ReadLine()); 
            if (i>0 )    // Esta solução, após determinar se é positivo, distingue se é ou não par (Português menos correto que a versão 2)
                Console.Write("O número inteiro {0} é positivo",i); // Não muda de linha
            else
                Console.Write("O número inteiro {0} não é positivo",i);
            if (i%2==0)   // A mudança de linha só ocorre após esta instrução
                Console.WriteLine(" e é par"); 
            else
                Console.WriteLine(" e não é par",i);
        }
    }
}
