/*
 * Exercicio 10.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
 DIVIDENDO: try
            {
                Console.Write("Introduza o dividendo (número inteiro): ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto DIVIDENDO;
            }
 DIVISOR:   try
            {
                Console.Write("Introduza o divisor (número inteiro <> 0): ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}/{1}={2} Resto:{3}", a, b, a / b, a % b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto DIVISOR;
            }
        }
    }
}
