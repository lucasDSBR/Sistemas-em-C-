using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double cotacao;
        public static double qtdComprar;
        public static double qtdPagar;


        public static void ValorSerPagoIof()
        {
            qtdPagar = qtdPagar + (qtdPagar * (6 / 100));
        }

        public static void Converter()
        {
            qtdPagar = cotacao * qtdComprar;
        }
    }
}
