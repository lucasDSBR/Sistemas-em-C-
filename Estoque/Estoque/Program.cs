using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);


            Console.WriteLine(p.Nome);

            p.SetNome(" ");

            Console.WriteLine(p.Nome);
        }
    }
}
