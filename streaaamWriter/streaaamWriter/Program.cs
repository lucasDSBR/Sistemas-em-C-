using System;
using System.IO;


namespace streaaamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Arquivos\file.txt";
            string targetPath = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Arquivos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
