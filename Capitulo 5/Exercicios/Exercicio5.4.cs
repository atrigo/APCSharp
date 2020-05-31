/*
 * Exercicio 5.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            float h, sh, s;
            Console.Write("Introduza um número de horas trabalhadas: ");    // Não é feita validação, ou seja, o utilizador pode 
            h = Convert.ToSingle(Console.ReadLine());                       // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o valor do salário por hora: "); 
            sh = Convert.ToSingle(Console.ReadLine());
            if (h <= 40) // Foram trabalhadas menos de 40 horas?
                s = h * sh; // Não há horas extraordinárias, as horas são todas pagas ao preço sh --> (h * sh)
            else
                s = 40 * sh + (h - 40) * sh * 2;    // As primeiras 40 horas são pagas ao preço normal --> (40 * sh), 
                                                    //as horas para além das 40 -->(h - 40), são pagas a dobrar --> (sh * 2)
                // alternativa à instrução anterior --> s= sh*(2*h-40)
            Console.WriteLine("Salário semanal: {0}",s);
        }
    }
}
