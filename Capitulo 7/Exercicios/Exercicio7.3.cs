/*
 * Exercicio 7.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


namespace Cap7
{
    class Program
    {
        static void linhaAster(int N)
        {
            for(int i=0;i<N;i++)
                Console.Write("*");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int N;
            Console.Write("Quantos asteriscos? ");
            N = Convert.ToInt32(Console.ReadLine());
            linhaAster(N);
        }
    }
}
