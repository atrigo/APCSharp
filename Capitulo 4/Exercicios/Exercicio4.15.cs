
/*
 * Exercicio 4.15
 * Enunciado:   Escreva um programa que converta a temperatura lida em graus 
 *              Fahrenheit para graus Celsius. A fórmula é C = 5/9 (F-32). 
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            float f;
            Console.Write("Introduza a temperatura em graus Farenheit: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0}°F={1:F2}°C",f,5/9F*(f-32)); //A divisão 5/9F é real porque 9 é do tipo float, sem a letra F a divisão seria inteira e conduziria a um resultado errado
            // Para que a divisão 5/9 seja real o numerador ou o denominador têm que ser reais
        }
    }
}
