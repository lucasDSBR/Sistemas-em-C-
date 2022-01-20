using System;
using System.Globalization;

namespace DadosFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void SalarioLiquido()
        {
            SalarioBruto =  SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcent)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcent / 100));
        }


        public override string ToString()
        {
            return "Funcionario:"
                + Nome
                + ", $ "
                + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
