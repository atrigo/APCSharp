/*
 * Memorizar 9.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Erro! \nNumero de parametros" +
                " diferente de 2. \nInsira dois numeros separados por" +
                "espacos.");
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}.", args[0],
                args[1], Convert.ToInt32(args[0]) +
                Convert.ToInt32(args[1]));
            }
        }
    }
}