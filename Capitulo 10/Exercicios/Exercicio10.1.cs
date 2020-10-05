/*
 * Exercicio 10.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

//Versao 1

using System;

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool continua;
            do
            {
                try
                {
                    Console.Write("Introduza um número inteiro: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    continua = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continua = true;
                }
            } while (continua);

        }
    }
}

//Versao 2

using System;

namespace Cap9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
 VALIDA:    try
            {
                Console.Write("Introduza um número inteiro: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto VALIDA;
            }
        }
    }
}
