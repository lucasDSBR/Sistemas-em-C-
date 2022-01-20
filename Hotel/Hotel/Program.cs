using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotell[] vet = new Hotell[10];

            Console.WriteLine("#########  HOTEL  #########");
            Console.WriteLine("Recepção/Cadastro:");

            Console.WriteLine("Quantos clientes desejam alugar quartos?");
            int totAlug = int.Parse(Console.ReadLine());

            for(int i = 0; i< totAlug; i++)
            {
                Console.WriteLine("Cliente #"+i);
                Console.WriteLine("Qual quarto deseja alugar? ");
                int quarto = int.Parse(Console.ReadLine());

                if(vet[quarto] == null)
                {
                    Console.WriteLine("Nome do cliente: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("E-mail do cliente: ");
                    string email = Console.ReadLine();
                    vet[quarto] = new Hotell { CliNome = nome, CliEmail = email, NumeroQuarto = quarto };
                }
                else
                {
                    Console.WriteLine("Desculpe. o quarto escolhido já está ocupado. Tente outro.");
                    i = i - 1;
                }

            }
            Console.WriteLine("Quartos alugados ou Livres:");
            for (int i = 0; i < vet.Length; i++)
            {
                
                if(vet[i] == null)
                {
                    Console.WriteLine("Quarto #"+i+": LIVRE");
                }
                else
                {
                    Console.WriteLine("Quarto #" + i + ": ALUGADO. Cliente: "+vet[i]);
                }
            }



        }
    }
}
