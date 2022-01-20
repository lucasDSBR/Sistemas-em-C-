using System;
using System.Globalization;

namespace UsuarioID
{
    class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Usuarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AcrescentandoSalario(double porcent)
        {
            Salario += (Salario*(porcent/100));
        }


        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
