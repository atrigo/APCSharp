/*
 * Exercicio 10.6
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
            char c;
            int tentativas = 0, tamanho = 10, nCarat, i,tenta=0;
            bool continua;
            do
            {
                try
                {
                    Console.Write("Quantas tentativas: ");
                    tenta = Convert.ToInt32(Console.ReadLine());
                    continua = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continua = true;
                }
            } while (continua);

            char[] p = new char[tamanho];
            string pass, pwd = "luar";
            do
            {
                Console.Clear();
                p.Initialize();
                pass = "";
                nCarat = 0;
                Console.Write("Introduza a password (letras maiúsculas/minúsculas e números - máx 10 caract): ");
                do
                {
                    c = Console.ReadKey(true).KeyChar;
                    if (c == 8)
                    {
                        if (nCarat > 0)
                        {
                            p[--nCarat] = (char)0;
                            Console.Write(c + " " + c);
                        }
                    }
                    else
                        if ((c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9') && nCarat < tamanho)
                    {
                        p[nCarat++] = c;
                        Console.Write("*");
                    }
                } while (c != 13);
                tentativas++;
                i = 0;
                while (i < tamanho && p[i] != 0)
                {
                    pass += p[i];
                    i++;
                }
            } while (pass != pwd && tentativas < tenta);
            if (pass == pwd)
                Console.WriteLine("\nPassword correta");
            else
                Console.WriteLine("\nExcedeu o número de tentativas");
        }
    }
}
