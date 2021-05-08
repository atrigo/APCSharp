using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap13
{
    class Program
    {
        static void Escrita()//Exercício 13.3
        {
            string s="";
            int c;
            try
            {
                StreamWriter sw = new StreamWriter("turma.txt");
                while (s != "sair")
                {
                    Console.Write("Introduza o nome: ");
                    s = Console.ReadLine();
                    if (s != "sair")
                    {
                        Console.Write("Introduza a classificação: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        sw.WriteLine("{0,-20}{1,-3}",s,c);
                    }

                }
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
        static void MelhorNota()//Exercício 13.4
        {
            string s="",n="";
            int c=0,ac;
            try
            {
                StreamReader sr = new StreamReader("turma.txt");
                while ((s=sr.ReadLine()) != null)
                {
                    ac = Convert.ToInt32(s.Substring(20, 3));
                    if (ac > c)
                    {
                        c = ac;
                        n = s.Substring(0, 20).TrimEnd();
                    }
                }
                Console.WriteLine("Melhor aluno: {0}\t{1}", n, c);
                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Escrita();
            MelhorNota();
        }
    }
}
