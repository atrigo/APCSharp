/*
 * Exercicio 5.10
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap5
{
    class Program             
    {
        static void Main(string[] args) 
        {
            float ps;
            int ta;
            Console.Write("Preço sem IVA: ");           // Não é feita validação, ou seja, o utilizador pode introduzir 
            ps = Convert.ToSingle(Console.ReadLine());  // caracteres inválidos e como tal gerar excepções (ERROS)
            Console.WriteLine("** Escolha o tipo de artigo **\n1- bens essenciais\n2- produtos de luxo\n3- restantes");  
            ta = Convert.ToInt32(Console.ReadLine());
            switch (ta)
            {
                case 1:Console.WriteLine("Preço com IVA: {0}",ps*(1+0.05F));break;
                case 2:Console.WriteLine("Preço com IVA: {0}",ps*(1+0.3F));break;
                case 3:Console.WriteLine("Preço com IVA: {0}",ps*(1+0.2F));break;
                default: Console.WriteLine("ERRO");break;
            }
        }
    }
}
