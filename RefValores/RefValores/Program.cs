using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = y ?? 5;


            Console.WriteLine(a);

            Console.WriteLine(b);
            /*Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.HasValue);
            }
            else
            {
                Console.WriteLine("x is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.HasValue);
            }
            else
            {
                Console.WriteLine("y is null");
            }*/




        }
    }
}
