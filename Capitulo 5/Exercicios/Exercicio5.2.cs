/*
 * Exercicio 5.2
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
            float r;
            int i;
            Console.Write("Introduza um valor real positivo: "); // Não é feita validação, ou seja, o utilizador pode introduzir um nº negativo
            r = Convert.ToSingle(Console.ReadLine()); 
            if (r - (int)r < 0.5)   // (r - (int)r) representa a parte decimal do nº real, se for menor que 0.5  
                i = (int)r;         //  arredonda por defeito
            else
                i = (int)r + 1;     // se não arredonda por excesso
            Console.WriteLine("Valor inteiro arredondado: {0}",i); 
        }
    }
}
