
/*
 * Exercicio 4.5
 * Enunciado: Escreva um programa que apresente os números 4,68805; 4,8; 5,9964; e 5 arredondados em 
 *            três linhas diferentes, sendo que na primeira linha aparecem todos arredondados 
 *            a três casas decimais, na segunda a duas e na terceira a uma casa decimal.
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
            Console.WriteLine("{0:F3}\t{1:F3}\t{2:F3}\t{3:F3}",4.68805,4.8,5.9964,5); // No IDE do Visual Studio utilize o ponto como separador decimal, na consola utilize a vírgula
            Console.WriteLine("{0:F2}\t{1:F2}\t{2:F2}\t{3:F2}",4.68805,4.8,5.9964,5); // \t - tabulador
            Console.WriteLine("{0:F1}\t{1:F1}\t{2:F1}\t{3:F1}",4.68805,4.8,5.9964,5);
        }
    }
}
