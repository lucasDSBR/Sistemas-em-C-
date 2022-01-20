using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar: ");
            ConversorDeMoeda.cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quanto você quer comprar: ");
            ConversorDeMoeda.qtdComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            ConversorDeMoeda.Converter();
            ConversorDeMoeda.ValorSerPagoIof();
            Console.WriteLine(ConversorDeMoeda.qtdPagar);

        }
    }
}
