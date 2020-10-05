/*
 * Exercicio 9.18
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void validaUtilizador(string[,] U)
        {
            char c;
            int tentativas = 0, tamanho = 10, nCarat, i;
            char[] p = new char[tamanho];
            string pass,user;
            do
            {
                Console.Clear();
                Console.Write("Introduza o username: ");
                user=Console.ReadLine();
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
            } while ((user!=U[0,0] || pass != U[0,1]) && tentativas < 3);
            if (pass == U[0,1] && user==U[0,0])
                Console.WriteLine("\nValidação correta");
            else
                Console.WriteLine("\nExcedeu o número de tentativas");
        }

        static void registaUtilizador(string[,] U)
        {
            char c;
            int nCarat= 0, tamanho = 10;
            char[] p = new char[tamanho];
            Console.Write("Introduza o username: ");
            U[0,0] = Console.ReadLine();
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
            int i = 0;
            while (i < tamanho && p[i] != 0)
            {
                U[0,1]+= p[i];
                i++;
            }
            Console.WriteLine();
        }

        static void Main(string[] args) // Implementação para 1 utilizador
        {
            string [,] Utilizadores=new string [1,2];
            registaUtilizador(Utilizadores);
            validaUtilizador(Utilizadores);
        }
    }
}
