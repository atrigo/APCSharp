/*
 * Exercicio 6.36
 * Enunciado: Escreva um programa que apresente no ecrã todas as capicuas até 10000.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, novo_numero;
            int digito;

            for (i = 10; i < 10000; i++)
            {
                n = i;
                novo_numero = 0;   
                while (n > 0)
                {
                    digito = n % 10;
                    novo_numero = novo_numero * 10 + digito;
                    n = n/10;
                }
                if (i == novo_numero)
                    Console.WriteLine(i);
            }
        }
    }
}


/*
Com utilização de vetores
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) 
        {
            uint i, j, k, n;
            uint[] v = new uint[9];
            bool cap;
            for (i = 1; i < 10000; i++)
            {
                n = i;
                j = 0;
                do
                {
                    v[j++] = n % 10;
                    n /= 10;
                }
                while (n > 0);
                cap = true;
                k = 0;
                do
                    if (v[j - 1 - k] != v[k++])
                        cap = false;
                while (j / 2 >= k && cap);
                if (cap)
                    Console.WriteLine(i);
            }
        }
    }
}
