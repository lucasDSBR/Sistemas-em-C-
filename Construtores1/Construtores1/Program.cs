using System;
using System.Globalization;

namespace Construtores1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());


            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto:" + p);

            Console.WriteLine("Digite um numero de produtos a serem adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarQuantidadeEstoque(qte);


            Console.WriteLine("Dados do produto:" + p);


            Console.WriteLine("Digite um numero de produtos a serem removidos do estoque: ");
            int rm = int.Parse(Console.ReadLine());
            p.RemoverProdutoEstoque(rm);

            Console.WriteLine("Dados do produto:" + p);
        }
    }
}
