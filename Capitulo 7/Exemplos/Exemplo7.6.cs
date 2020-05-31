/*
 * Exemplo 7.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void TestaEmail(string email, out bool arroba,
            out bool duasArrobas, out bool pontoDepoisDaArroba)
        {
            arroba = false;
            duasArrobas = false;
            pontoDepoisDaArroba = false;

            if (email.Contains("@"))
                arroba = true;
            if (email.IndexOf("@") != email.LastIndexOf("@"))
                duasArrobas = true;
            if (email.LastIndexOf(".") > email.LastIndexOf("@"))
                pontoDepoisDaArroba = true;
        }

        static void Main(string[] args)
        {
            string frase;
            bool arroba;
            bool duasArrobas;
            bool pontoDepoisDaArroba;

            Console.Write("Insira um email:");
            frase = Console.ReadLine();
            TestaEmail(frase, out arroba, out duasArrobas, out pontoDepoisDaArroba);
            if (arroba && !duasArrobas && pontoDepoisDaArroba)
                Console.WriteLine("Email valido.");
            else
            {
                Console.WriteLine("Email invalido.");
                if (!arroba)
                    Console.WriteLine("Falta a arroba (@) no email.");
                else if (duasArrobas)
                    Console.WriteLine("O email nao pode ter duas arrobas.");
                else if (!pontoDepoisDaArroba)
                    Console.WriteLine("Falta um ponto depois da arroba no email.");
            }
        }
    }
}
