using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace CalculoLadoTrianguos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Entre com os valores das medidas do Triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com os valores das medidas do Triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.CalcularArea();


            double areay = y.CalcularArea();


            Console.WriteLine($"A área de X é: {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A área de Y é: {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areax > areay)
            {
                Console.WriteLine("A maior área é a do triângulo X");
            }
            else if(areax < areay)
            {
                Console.WriteLine("A maior área é a do triângulo Y");
            }

        }
    }
}
