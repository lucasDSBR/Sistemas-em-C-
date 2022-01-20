using System;
using System.Collections.Generic;
using System.Globalization;

namespace UsuarioID
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Usuarios> list = new List<Usuarios>();

            Console.WriteLine("Quantas pessoa deseja cadastrar ?: ");
            int totPessCad = int.Parse(Console.ReadLine());
            for (int i = 0; i < totPessCad; i++)
            {
                Console.WriteLine("Id do usuario");
                int idUser = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do usuario: ");
                string NomeUser = Console.ReadLine();

                Console.WriteLine("Salario do usuario");
                double SalarioUser = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Usuarios(idUser, NomeUser, SalarioUser));
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("USUARIOS");
            foreach(Usuarios obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Informe o ID de um usuario: ");
            int idSearch = int.Parse(Console.ReadLine());


            Usuarios procura = list.Find(x => x.Id == idSearch);

            if(procura != null)
            {
                Console.WriteLine("Qual a porcentagem?: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                procura.AcrescentandoSalario(porcent);
            }


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("USUARIOS ATUALIZADOS");
            foreach (Usuarios obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------------------------------");
        }
    }
}
