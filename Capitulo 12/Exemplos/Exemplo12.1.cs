/*
 * Exemplo 12.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            object o = i;  // Boxing implicito
            try
            {
                int j = (short)o;  // conversao explicita com tentativa de realizacao de casting
                Console.WriteLine("Unboxing realizado com sucesso.");
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine("{0} Erro no unboxing.", e.Message);
            }
        }
    }
}