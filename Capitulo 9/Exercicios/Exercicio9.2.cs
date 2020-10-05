/*
 * Exercicio 9.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,apelido;
            Console.Write("Introduza o seu nome próprio: ");
            nome = Console.ReadLine();
            Console.Write("Introduza o seu apelido: ");
            apelido = Console.ReadLine();
            Console.WriteLine("O seu nome completo é {0} {1}", nome,apelido);
        }
    }
}
