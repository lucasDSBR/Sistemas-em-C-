using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo l;

            l = new Retangulo();


            Console.WriteLine("Entre com a Largura e Altura do Triângulo:");
            l.Largura = double.Parse(Console.ReadLine());
            l.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(l);
        }
    }
}
