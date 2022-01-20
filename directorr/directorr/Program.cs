using System;
using System.IO;
using System.Collections.Generic;


namespace directorr
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Myfolder";


            try
            {
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");

                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }


                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");

                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\\novoArquivo");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
