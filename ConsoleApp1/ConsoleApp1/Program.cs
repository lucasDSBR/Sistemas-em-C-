using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];


            Console.WriteLine(frase);
            Console.WriteLine($"{x} --- {y} --- {z}");
            Console.WriteLine($"{p1} --- {p2} --- {p3}");
            */


            int numero = int.Parse(Console.ReadLine());
            char genero = char.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ') ;

            string p1 = vet[0];
            char p2 = char.Parse(vet[1]);
            int p3 = int.Parse(vet[2]);
            double p4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(numero);
            Console.WriteLine(genero);
            Console.WriteLine(valor);

            Console.WriteLine($"{p1} --- {p2} --- {p3} --- {p4}");

        }
    }
}
