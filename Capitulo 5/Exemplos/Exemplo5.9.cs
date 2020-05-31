/*
 * Exemplo 5.9
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
            Console.WriteLine("Insira um numero:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira outro numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a operacao que deseja realizar (*,+,-,/):");
            operacao = Convert.ToChar(Console.ReadLine());
            if (operacao == '*')
                Console.WriteLine("O resultado e: " + (num1 * num2));
            else
                if (operacao == '+')
                Console.WriteLine("O resultado e: " + (num1 + num2));
            else
                    if (operacao == '-')
                Console.WriteLine("O resultado e: " + (num1 - num2));
            else
                        if (operacao == '/')
                if (num2 != 0)
                    Console.WriteLine("O resultado e: " + (num1 / num2));
                else
                    Console.WriteLine("Nao e possivel dividir por 0.");
        }
    }
}
