/*
 * Exemplo 9.8
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
            string s = "De livro fechado nao sai letrado.";
            Console.WriteLine(s);
            s = s.Replace("livro", "caderno"); //Troca a string livro por caderno
            Console.WriteLine(s);
            s = s.Replace(' ', '_'); //Toca os espacos por underscores
            Console.WriteLine(s);
            string s2 = "letrado";
            int i = s.IndexOf(s2); //Encontra o indice da primeira ocorrencia da palavra letrado
            if (i >= 0)
            {
                s = s.Remove(i, s2.Length); //Remove todos os caracteres da palavra letrado
            }
            Console.WriteLine(s);
            string s3 = s.Substring(3, 7); //Retira a palavra caderno
            Console.WriteLine(s3);
            s = s.ToUpper(); //Converte para maiusculas
            Console.WriteLine(s);
            string[] palavras = s.Split('_'); //Separa a string por palavras
            foreach (string p in palavras)
                Console.WriteLine(p);
        }
    }
}
