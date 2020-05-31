/*
 * Exercicio 5.15
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

//Versão 1
using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mês;
            Console.Write("Introduza o dia de nascimento: ");  // Não é feita validação, ou seja, o utilizador pode 
            dia = Convert.ToInt32(Console.ReadLine());       // introduzir caracteres inválidos e gerar excepções (ERROS)
            Console.Write("Introduza o mês de nascimento: ");
            mês = Convert.ToInt32(Console.ReadLine());       
            if ((mês == 1 && dia >= 20 && dia <= 31) || (mês == 2 && dia >= 1 && dia <= 18))
                Console.WriteLine("Aquário");
            else 
                if ((mês == 2 && dia >= 19 && dia <= 29) || (mês == 3 && dia >= 1 && dia <= 20))
                    Console.WriteLine("Peixes");
                else 
                    if ((mês == 3 && dia >= 21 && dia <= 31) || (mês == 4 && dia >= 1 && dia <= 19))
                        Console.WriteLine("Carneiro");
                    else 
                        if ((mês == 4 && dia >= 21 && dia <= 30) || (mês == 5 && dia >= 1 && dia <= 20))
                            Console.WriteLine("Touro");
                        else 
                            if ((mês == 5 && dia >= 21 && dia <= 31) || (mês == 6 && dia >= 1 && dia <= 20))
                                Console.WriteLine("Gémeos");
                            else 
                                if ((mês == 6 && dia >= 21 && dia <= 30) || (mês == 7 && dia >= 1 && dia <= 21))
                                    Console.WriteLine("Caranguejo");
                                else 
                                    if ((mês == 7 && dia >= 22 && dia <= 31) || (mês == 8 && dia >= 1 && dia <= 22))
                                        Console.WriteLine("Leão");
                                    else 
                                        if ((mês == 8 && dia >= 23 && dia <= 31) || (mês == 9 && dia >= 1 && dia <= 22))
                                            Console.WriteLine("Virgem");
                                        else 
                                            if ((mês == 9 && dia >= 23 && dia <= 30) || (mês == 10 && dia >= 1 && dia <= 22))
                                                Console.WriteLine("Balança");
                                            else 
                                                if ((mês == 10 && dia >= 23 && dia <= 31) || (mês == 11 && dia >= 1 && dia <= 21))
                                                    Console.WriteLine("Escorpião");
                                                else 
                                                    if ((mês == 11 && dia >= 22 && dia <= 30) || (mês == 12 && dia >= 1 && dia <= 21))
                                                        Console.WriteLine("Sagitário");
                                                    else 
                                                        if ((mês == 12 && dia >= 22 && dia <= 31) || (mês == 1 && dia >= 1 && dia <= 20))
                                                            Console.WriteLine("Capricórnio");
                                                        else
                                                            Console.WriteLine("Data inválida");
        }
    }
}


//Versão 2

using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mês;
            Console.Write("Introduza o dia de nascimento: ");   
            dia = Convert.ToInt32(Console.ReadLine());       
            Console.Write("Introduza o mês de nascimento: ");
            mês = Convert.ToInt32(Console.ReadLine());
            switch (mês)
            {
                case 1:
                    if (dia < 20)
                        Console.WriteLine("Capricórnio");
                    else
                        Console.WriteLine("Aquário");
                    break;
                case 2:
                    if (dia < 19)
                        Console.WriteLine("Aquário");
                    else
                        Console.WriteLine("Peixes");
                    break;
                case 3:
                    if (dia < 21)
                        Console.WriteLine("Peixes");
                    else
                        Console.WriteLine("Carneiro");
                    break;
                case 4:
                    if (dia < 21)
                        Console.WriteLine("Carneiro");
                    else
                        Console.WriteLine("Touro");
                    break;
                case 5:
                    if (dia < 21)
                        Console.WriteLine("Touro");
                    else
                        Console.WriteLine("Gémeos");
                    break;
                case 6:
                    if (dia < 21)
                        Console.WriteLine("Gémeos");
                    else
                        Console.WriteLine("Caranguejo");
                    break;
                case 7:
                    if (dia < 22)
                        Console.WriteLine("Caranguejo");
                    else
                        Console.WriteLine("Leão");
                    break;
                case 8:
                    if (dia < 23)
                        Console.WriteLine("Leão");
                    else
                        Console.WriteLine("Virgem");
                    break;
                case 9:
                    if (dia < 23)
                        Console.WriteLine("Virgem");
                    else
                        Console.WriteLine("Balança");
                    break;
                case 10:
                    if (dia < 23)
                        Console.WriteLine("Balança");
                    else
                        Console.WriteLine("Escorpião");
                    break;
                case 11:
                    if (dia < 22)
                        Console.WriteLine("Escorpião");
                    else
                        Console.WriteLine("Sagitário");
                    break;
                case 12:
                    if (dia < 22)
                        Console.WriteLine("Sagitário");
                    else
                        Console.WriteLine("Capricórnio");
                    break;
                default:
                    Console.WriteLine("Data inválida");
                    break;
            }
        }
    }
}
