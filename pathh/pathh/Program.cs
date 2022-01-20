using System;
using System.IO;

namespace pathh
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Arquivos salvos\Eng. da Computação\Projetos_C#\Myfolder";

            Console.WriteLine("GetDirectoryName: "+ Path.GetDirectoryName(path));
            Console.WriteLine("PathSeparator: "+Path.PathSeparator);
            Console.WriteLine("DirectorySeparatorChar: "+Path.DirectorySeparatorChar);
            Console.WriteLine("FileName: " + Path.GetFileName(path));
        }
    }
}
