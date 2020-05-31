/*
 * Exemplo 3.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        enum DiasDaSemana
        {
            Domingo, Segunda, Terca, Quarta, Quinta,
            Sexta, Sabado
        };
        static void Main(string[] args)
        {
            Console.WriteLine("{0} = {0} ", DiasDaSemana.Domingo, (int) DiasDaSemana.Domingo);
            DiasDaSemana diaFavorito = DiasDaSemana.Sexta;
            Console.WriteLine("O meu dia favorito e' {0} ", diaFavorito);
            diaFavorito = (DiasDaSemana)4;
            Console.WriteLine("O meu dia favorito e' {0} ",
            diaFavorito);
        }
    }
}
