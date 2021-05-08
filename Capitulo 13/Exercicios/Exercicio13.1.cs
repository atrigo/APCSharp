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
        static void Escrita()//Exercício 13.1
        {
            string s="";
            try
            {
                StreamWriter sw = new StreamWriter("nomes.txt");
                while (s != "sair")
                {
                    Console.Write("Introduza o nome: ");
                    s = Console.ReadLine();
                    if (s != "sair")
                        sw.WriteLine(s);
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
        static void Leitura()//Exercício 13.2
        {
            string s="";
            try
            {
                StreamReader sr = new StreamReader("nomes.txt");
                while ((s=sr.ReadLine()) != null)
                    Console.WriteLine(s.ToUpper());
                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //Escrita();
            Leitura();
        }
    }
}
