using System;
using System.IO;

namespace filee
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Arquivos\file.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    Console.WriteLine(line);

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
