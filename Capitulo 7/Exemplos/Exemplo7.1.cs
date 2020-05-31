/*
 * Exemplo 7.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static float Quadrado(float num)
        { //Parametro
            return num * num;
        }
        static void Main(string[] args)
        {
            const float pi = 3.1416F;
            float r, alt;
            Console.WriteLine("Calculo da area e volume do cilindro:");
            Console.Write("Raio: ");
            r = Convert.ToSingle(Console.ReadLine());
            Console.Write("Altura: ");
            alt = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Area: {0:F}", pi * Quadrado(r) + 2 * pi * r * alt); // Passagem do argumento r
            //Resultado para raio = 3 e altura = 4:  Area: 103,67
            Console.WriteLine("Volume: {0:F}", pi * Quadrado(r) * alt); // Passagem do argumento r
            //Resultado para raio = 3 e altura = 4: Volume: 113,10
        }
    }
}
