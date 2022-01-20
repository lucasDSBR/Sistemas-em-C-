using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public double Saldo { get; private set; }
        public string Nome { get; set;}
        public int NumConta { get; private set; }

        public Conta(int numConta, string nome)
        {
            Nome = nome;
            NumConta = numConta;
        }
        public Conta(int numConta, string nome, double saldo) : this (numConta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valordep)
        {
            Saldo = Saldo + valordep;
        }

        public void Saque(double valorsaq)
        {
            Saldo = Saldo - valorsaq;
        }



        public override string ToString()
        {
            return "Dados da Conta: \n"
                + "Conta: "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
