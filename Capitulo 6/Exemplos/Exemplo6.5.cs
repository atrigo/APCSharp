/*
 * Exemplo 6.5
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
            int candidatoA = 0, candidatoB = 0, candidatoC = 0, numeroVotantes;
            string voto;
            Console.Write("Insira o numero de votantes:");
            numeroVotantes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numeroVotantes; i++)
            {
                Console.Write("Indique em que candidato deseja votar (A, B ou C):");
                voto = Console.ReadLine();
                switch (voto)
                {
                    case "A":
                        candidatoA++;
                        break;
                    case "B":
                        candidatoB++;
                        break;
                    case "C":
                        candidatoC++;
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            }
            Console.WriteLine("O numero de votos por candidato foi:");
            Console.WriteLine("A: {0}, B: {1}, C: {2}", candidatoA, candidatoB, candidatoC);
        }
    }
}
