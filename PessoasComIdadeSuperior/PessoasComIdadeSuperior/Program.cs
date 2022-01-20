using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoasComIdadeSuperior
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1, p2;

            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Informe o nome da primeira pessoa:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Agora, informe a idade dela: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da segunda pessoa:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Agora, informe a idade dela: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.nome} possui uma idade superior a de {p2.nome}");
            }else if (p2.idade > p1.idade)
            {
                Console.WriteLine($"{p2.nome} possui uma idade superior a de {p1.nome}");
            }
        }
    }
}
