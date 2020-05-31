/*
 * Exemplo 4.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1{
    class Program{
        public static void Main(string[] args){
            //Ler um inteiro
            Console.WriteLine("Insira num numero inteiro:");
            int numeroInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0:D}", numeroInt);
            //Ler um real (float)
            Console.WriteLine("Insira num numero real:");
            float numeroFloat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0:F2}", numeroFloat);
            //Ler um real (double)
            Console.WriteLine("Insira num numero real:");
            double numeroDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:F2}", numeroDouble);
            //Ler um caracter
            Console.WriteLine("Insira num caracter:");
            char car = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}", car);
}}}
