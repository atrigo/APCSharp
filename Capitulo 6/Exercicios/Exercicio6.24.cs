/*
 * Exercicio 6.24
 * Enunciado:   Altere o programa anterior permitindo ao utilizador informar as populações e as taxas de crescimento iniciais. 
 *              Valide a entrada e permita repetir a operação.
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
            double A, B,a,tcA,tcB;
            char c;
            do
            {
                a = 0;
                Console.Write("Qual a população do país A: ");
                A = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.Write("Qual a taxa de crescimento da população do país A: ");
                    tcA = Convert.ToDouble(Console.ReadLine());
                } while (tcA < 0 || tcA > 1);//Validação da taxa de crescimento para valores entre 0 e 1
                Console.Write("Qual a população do país B ( B>A): ");
                B = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.Write("Qual a taxa de crescimento da população do país B: ");
                    tcB = Convert.ToDouble(Console.ReadLine());
                } while (tcB < 0 || tcB > 1);//Validação da taxa de crescimento para valores entre 0 e 1
                if(A>=B && tcB<=tcA)
                    Console.WriteLine("A população do país A nunca igualará ou ultrapassará a população do país B");
                else
                {
                    while (A < B)
                    {
                        A *= (1 + tcA);
                        B *= (1 + tcB);
                        a++;
                    }
                    Console.WriteLine("A população do país A igualará ou ultrapassará a população do país B em {0} anos", a);
                }
                Console.Write("Pretende fazer outra simulação (s/n): ");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 's');
        }
    }
}
