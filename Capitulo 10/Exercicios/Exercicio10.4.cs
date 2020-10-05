/*
 * Exercicio 10.4
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, soma=0,N=0;
            string resposta;
            bool continua;
            do
            {

                do
                {
                    try
                    {
                        Console.Write("Introduza um número inteiro: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        continua = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continua = true;
                    }
                } while (continua);
                N++;
                soma += num;
                do
                {
                    Console.Write("Pretende continuar (Sim/Não)?");
                    resposta = Console.ReadLine();
                } while (resposta != "Sim" && resposta != "Não");
            } while (resposta == "Sim");
            Console.WriteLine("Média: {0}",soma/(float)N);
        }
    }
}
