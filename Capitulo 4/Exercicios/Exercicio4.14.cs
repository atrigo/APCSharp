
/*
 * Exercicio 4.14
 * Enunciado: Escreva um programa que converta dólares americanos para euros.
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
            float d,t=1.22595F;// Taxa de câmbio: 1,22595 - a letra F no fim do número significa que é do tipo float, sem o F seria considerado do tipo double e originaria um erro na atribuição
            Console.Write("Quantos dólares pretende converter: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            d = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("${0}={1}EUR",d,d*t); 
        }
    }
}
