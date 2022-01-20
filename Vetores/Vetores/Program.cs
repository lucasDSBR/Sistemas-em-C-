using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            double[] vect = new double[v];

            for (int i = 0; i < v; i++)
            {
                Console.WriteLine($"Escreva o {i} altura:");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < v; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
