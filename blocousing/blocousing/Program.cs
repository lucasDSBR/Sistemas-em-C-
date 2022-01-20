using System;
using System.IO;

namespace blocousing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Arquivos\fil2e.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
