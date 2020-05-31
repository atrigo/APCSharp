/*
 * Exemplo 5.14
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operacao;
            Console.Write("Insira um numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira outro numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira a operacao que deseja realizar (*,+,-,/):");
            operacao = Convert.ToChar(Console.ReadLine());
            switch (operacao)
            {
                case '*':
                    Console.WriteLine("O resultado e: " + (num1 * num2));
                    break;
                case '+':
                    Console.WriteLine("O resultado e: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("O resultado e: " + (num1 - num2));
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine("O resultado e: " + (num1 / num2));
                    else
                        Console.WriteLine("Nao e possivel dividir por 0.");
                    break;
                default:
                    Console.WriteLine("Operacao invalida");
                    break;
            }
        }
    }
}
