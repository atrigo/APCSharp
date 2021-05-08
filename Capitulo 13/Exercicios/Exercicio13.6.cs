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
        static void Escrita()//Exercício 13.5
        {
            string s="";
            int c;
            try
            {
                StreamWriter sw = new StreamWriter("turmaSep.txt");
                while (s != "sair")
                {
                    Console.Write("Introduza o nome: ");
                    s = Console.ReadLine();
                    if (s != "sair")
                    {
                        Console.Write("Introduza a classificação: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        sw.WriteLine("{0},{1}",s,c);
                    }

                }
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
        static void Media()//Exercício 13.6
        {
            string s="";
            string[] v;
            int total = 0, cont = 0;
            try
            {
                StreamReader sr = new StreamReader("turmaSEP.txt");
                while ((s=sr.ReadLine()) != null)
                {
                    v = s.Split(',');
                    total += Convert.ToInt32(v[1]);
                    cont++;
                }
                Console.WriteLine("Média {0}", total / (float)cont);
                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
        static void Aprovados()//Exercício 13.7
        {
            string s="";
            string[] v;
            try
            {
                StreamReader sr = new StreamReader("turmaSEP.txt");
                Console.WriteLine("*** Aprovados ***");
                while ((s=sr.ReadLine()) != null)
                {
                    v = s.Split(',');
                    if(Convert.ToInt32(v[1])>9)
                        Console.WriteLine("{0,-20}{1,-3}", v[0],v[1]); 
                }
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
            Media();
            Aprovados();
        }
    }
}
