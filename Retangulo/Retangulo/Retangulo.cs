using System;

namespace Retangulo
{
    class Retangulo
    {
        //Variáveis
        public double Largura;
        public double Altura;

        //Funções:
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return "Área do Retangulo: "
                + Area()
                + ", Perímetro do Retangulo: "
                + Perimetro()
                + ", Diagonal do Retangulo: "
                + Diagonal();


        }
    }
}
