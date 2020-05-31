/*
 * Exercicio 7.5
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap7
{
    class Program
    {
        static int soma(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b)
        {
            return a - b;
        }

        static int mult(int a, int b)
        {
            return a * b;
        }

        static double div(int a, int b)
        {
            return (double)a / b;
        }

        static void Main(string[] args)
        {
            int op1, op2;
            string op;
            Console.Write("Introduza o 1º operando: ");
            op1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o 2º operando: ");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o operador: ");
            op = Console.ReadLine();
            switch (op)
            {
                case "+": Console.WriteLine("{0}+{1}={2}", op1, op2, soma(op1, op2)); break;
                case "-": Console.WriteLine("{0}-{1}={2}", op1, op2, sub(op1, op2)); break;
                case "*": Console.WriteLine("{0}*{1}={2}", op1, op2, mult(op1, op2)); break;
                case "/": Console.WriteLine("{0}/{1}={2}", op1, op2, div(op1, op2)); break;
                default: Console.WriteLine("Operador inválido"); break;
            }

        }
    }
}
