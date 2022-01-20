using System;
using System.Globalization;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p;

            p = new Funcionario();


            Console.WriteLine("Digite o nome do funcionario: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario bruto do funcionario");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual o valor do imposto?: ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.SalarioLiquido();
            Console.WriteLine(p);

            Console.WriteLine($"Digite uma porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            p.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: "+p);

        }
    }
}
