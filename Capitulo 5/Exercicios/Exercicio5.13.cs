/*
 * Exercicio 5.13
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
            int a, b, c;
            double d;
            Console.Write("Introduza o valor de a: ");  // Não é feita validação, ou seja, o utilizador pode 
            a = Convert.ToInt32(Console.ReadLine());       // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o valor de b: ");  
            b = Convert.ToInt32(Console.ReadLine());       
            Console.Write("Introduza o valor de c: ");  
            c = Convert.ToInt32(Console.ReadLine());
            d = Math.Pow(b ,2) - 4 * a * c; // se d<0 as raízes serão complexas
            if(d<0)
                Console.WriteLine("R1:{0:F2}+{1:F2}i\tR2:{2:F2}-{3:F2}i",-b/2*a,Math.Sqrt(-d)/2*a,-b/2*a,Math.Sqrt(-d)/2*a);
            else
                Console.WriteLine("R1:{0:F2}\tR2:{1:F2}",(-b+Math.Sqrt(d))/2*a,(-b-Math.Sqrt(d))/2*a);
        }
    }
}
