/*
 * Exemplo 11.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    public class Carro
    {
        int posX;
        int posY;
        string nome;
        public int Cor { get; set; }

        public Carro()
        {
        }
        public Carro(string nome, int posX, int posY, int cor)
        {
            this.nome = nome;
            this.posX = posX;
            this.posY = posY;
            this.Cor = cor;
        }

        public void MostrarMovimento()
        {
            Console.WriteLine("O carro {0} moveu-se para a posicao ({1},{2})", nome, posX, posY);
        }
        public void MoverDireita() { posX++; }
        public void MoverEsquerda() { posX--; }
        public void MoverCima(int x) { posY++; }
        public void MoverDireita(int x) { posY--; }
        ~Carro()
        {
            Console.WriteLine("Este carro vai desaparecer do ecra!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Carro a inicializado com nome ''Mini Cooper'', posicao x = 1, posicao y = 2 e cor = 0 (Vermelho)
            Carro a = new Carro("Mini Cooper", 1, 2, 0);
            a.MoverEsquerda();
            a.Cor = 1; //Cor alterada para azul
            a.MostrarMovimento();
        }
    }
}