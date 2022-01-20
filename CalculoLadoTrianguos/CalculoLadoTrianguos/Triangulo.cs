using System;

namespace CalculoLadoTrianguos
{
    class Triangulo
    {
        //Variaveis para armazenar dados do trangulo
        public double A;
        public double B;
        public double C;

        //Função para calcular área do trangulo
        public double CalcularArea()
        {
            double p = ((A + B + C) / 2.0);
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
