using System;
using System.IO;


namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Arquivos\file.txt";
            string targetPath = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
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
