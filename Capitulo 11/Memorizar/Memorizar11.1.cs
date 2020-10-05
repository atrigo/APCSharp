/*
 * Exemplo 11.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    public class Pessoa
    {
        string nome;
        int idade;
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        override
        public string ToString()
        {
            return this.nome;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Matilde", 13);
            Console.WriteLine(p);
        }
    }
}
