using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.WriteLine("Entre com o numero da conta: ");
            int NumConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito na conta (s/n)? ");
            string dep = Console.ReadLine();
            
            if (dep == "s")
            {
                //chamar deposito
                Console.WriteLine("Entre com um valor inicial: ");
                double valDep1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(NumConta, Nome, valDep1);
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine(conta );

            Console.WriteLine("\n\nEntre com um valor para deposito: ");
            double valDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valDep);

            Console.WriteLine(p);

            Console.WriteLine("\n\nEntre com um valor para saque: ");
            double valSaq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Saque(valSaq);

            Console.WriteLine(p);


        }
    }
}
