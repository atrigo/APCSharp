/*
 * Exemplo 13.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "Algoritmos";
            try
            {
                bw = new BinaryWriter(new FileStream("ficheiro.dat", FileMode.Create));
                try
                {
                    bw.Write(i);
                    bw.Write(d);
                    bw.Write(b);
                    bw.Write(s);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message + "\n Nao e possivel escrever no ficheiro.");
                }
                bw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Nao e possivel criar o ficheiro.");
            }            
            //leitura do ficheiro
            try
            {
                br = new BinaryReader(new FileStream("ficheiro.dat", FileMode.Open));
                try
                {
                    i = br.ReadInt32();
                    Console.WriteLine("Integer data: {0}", i);
                    d = br.ReadDouble();
                    Console.WriteLine("Double data: {0}", d);
                    b = br.ReadBoolean();
                    Console.WriteLine("Boolean data: {0}", b);
                    s = br.ReadString();
                    Console.WriteLine("String data: {0}", s);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message + "\n Nao e possivel ler o ficheiro.");
                }
                br.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Nao e possivel abrir o ficheiro.");
            }
            Console.ReadKey();
        }
    }
}