/*
 * Exercicio 6.5
 * Enunciado: Altere o programa anterior para mostrar no final a soma dos números.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inf, sup, i, soma=0;
            Console.Write("Introduza o limite inferior do intervalo: ");     // Não é feita validação, ou seja, o utilizador pode  introduzir 
            inf = Convert.ToInt32(Console.ReadLine());                      //valores incorrectos ou caracteres inválidos e  como tal gerar excepções (ERROS)
            Console.Write("Introduza o limite superior do intervalo: ");
            sup = Convert.ToInt32(Console.ReadLine());
            for (i = inf; i <= sup; i++) // Ciclo com i a variar entre inf e sup
            {
                Console.Write("{0}",i);
                if(i!=sup)      // Se não for o último número acrescenta o operador +
                    Console.Write("+"); 
                soma += i;      //Vai adicionando cada um dos números à variável soma
            }
            Console.Write("={0}\n",soma); 
        }
    }
}
