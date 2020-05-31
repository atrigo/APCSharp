/*
 Exercicio 6.26
 Livro: Aprenda a programar com C#
 Autores: Antonio Trigo e Jorge Henriques
 Disponível em: http://www.silabo.pt
 
 Um número perfeito é um número natural para o qual a soma de todos os seus divisores
 naturais próprios (excluindo ele mesmo) é igual ao próprio número. 
 Exemplos de números perfeitos: 6, 28, 496, 8128, ...
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) 
        {
            int j,n, soma=1; // A soma é inicializada em 1 porque o teste dos divisores começa em 2 já que 1 é divisor de todos os nºs
            Console.Write("Qual o número? ");
            n = Convert.ToInt32(Console.ReadLine());
            for (j = 2; j <= (Math.Sqrt((float)n)); j++)
                if (n % j == 0)
                    if (j == n / j)
                        soma += j;
                    else
                        soma += j + n / j;
            if(soma == n)
                Console.WriteLine("{0} é um número perfeito",n);
            else
                Console.WriteLine("{0} não é um número perfeito",n);
        }
    }
}
