/*
 * Exemplo Jogo da Cobra
 * Livro: Aprender a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static int lins = 30, cols = 79;
        static int[,] cobra = new int[500, 2]; //Guarda as posicoes xy da cobra
        static int posXCobra = 5, posYCobra = 5;
        static int posXComida, posYComida;
        static int tamCobra = 3, tempoEspera = 150, pontos = 0;
        static bool fimDoJogo = false;
        enum Direcao { Direita, Esquerda, Cima, Baixo };
        static void DesenharArea()
        {
            for (int i = 0; i < lins; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == lins - 1)
                        Console.Write("*");
                    else
                        if (j == 0 || j == cols - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void IniciarCobra()
        {
            for (int i = 0; i < tamCobra; i++)
            {
                cobra[i, 0] = posXCobra;
                cobra[i, 1] = posYCobra;
                posXCobra--;
            }
            for (int i = 0; i < tamCobra; i++)
            {
                Console.SetCursorPosition(cobra[i, 0], cobra[i, 1]);
                Console.Write("*");
            }
        }
        static void Andar(Direcao d)
        {
            //direcao = 0 -> direita; 1 -> esquerda; 2 -> cima; 3 ->baixo        
            int i = 0;
            Console.SetCursorPosition(cobra[tamCobra - 1, 0], cobra[tamCobra - 1, 1]);
            Console.Write(" ");
            for (i = tamCobra - 1; i > 0; i--)
            {
                cobra[i, 0] = cobra[i - 1, 0];
                cobra[i, 1] = cobra[i - 1, 1];
            }
            switch (d)
            {
                case Direcao.Direita:
                    ++cobra[0, 0];
                    break;
                case Direcao.Esquerda:
                    --cobra[0, 0];
                    break;
                case Direcao.Baixo:
                    ++cobra[0, 1];
                    break;
                case Direcao.Cima:
                    --cobra[0, 1];
                    break;
            }
            Console.SetCursorPosition(cobra[0, 0], cobra[0, 1]);
            Console.Write("*");
            if (ColidiuComAPropriaCobra(cobra[0, 0], cobra[0, 1]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(30, 8);
                Console.Write("****GAME OVER****");
                Console.SetCursorPosition(30, 10);
                Console.Write("ColidiuComAParede com a cobra!");
                Console.SetCursorPosition(30, 12);
                Console.Write("Pontuacao: {0}", pontos);
                fimDoJogo = true;
            }
        }
        static void ColidiuComAParede()
        {
            if (cobra[0, 0] == 0 || cobra[0, 0] == cols - 1 ||
                cobra[0, 1] == 0 || cobra[0, 1] == lins - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(30, 8);
                Console.Write("****GAME OVER****");
                Console.SetCursorPosition(30, 10);
                Console.Write("ColidiuComAParede com a parede!");
                Console.SetCursorPosition(30, 12);
                Console.Write("Pontuacao: {0}", pontos);
                fimDoJogo = true;
            }
        }
        static void DesenharComida()
        {
            bool sobrepoe = true;
            do
            {
                Random rnd = new Random();
                posXComida = rnd.Next(1, cols - 1);
                posYComida = rnd.Next(1, lins - 1);
                sobrepoe = false;
                for (int i = 0; i < cobra.GetLength(0); i++)
                {
                    if (cobra[i, 0] == posXComida && cobra[i, 1] == posYComida)
                    {
                        sobrepoe = true;
                    }
                }
            }
            while (sobrepoe == true);
            Console.SetCursorPosition(posXComida, posYComida);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Encontrou()
        {
            if (posXComida == cobra[0, 0] && posYComida == cobra[0, 1])
            {
                DesenharComida();
                tamCobra += 10;
                tempoEspera -= 5;
                pontos += 10;
            }
        }
        static bool ColidiuComAPropriaCobra(int posX, int posY)
        {
            int i;
            for (i = 1; i < tamCobra; i++)
            {
                if (cobra[i, 0] == posX && cobra[i, 1] == posY)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            DesenharArea();
            IniciarCobra();
            DesenharComida();
            Direcao d = Direcao.Direita;
            Console.SetWindowSize(80, 30);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case ConsoleKey.RightArrow:
                            d = Direcao.Direita;
                            break;
                        case ConsoleKey.LeftArrow:
                            d = Direcao.Esquerda;
                            break;
                        case ConsoleKey.DownArrow:
                            d = Direcao.Baixo;
                            break;
                        case ConsoleKey.UpArrow:
                            d = Direcao.Cima;
                            break;
                        default:
                            break;
                    }
                }
                if (!fimDoJogo)
                {
                    Andar(d);
                    ColidiuComAParede();
                    Encontrou();
                    System.Threading.Thread.Sleep(tempoEspera);
                }
            }
        }
    }
}
