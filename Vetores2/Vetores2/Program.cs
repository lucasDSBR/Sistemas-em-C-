using System;
using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];


            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double precoMedio = 0.0;

            for(int i = 0; i < n; i++)
            {
                precoMedio += vect[i].Preco;
            }

            Console.WriteLine("Preço médio = " + (precoMedio/2));
        }
    }
}
