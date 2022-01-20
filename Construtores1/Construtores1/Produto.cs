using System.Globalization;

namespace Construtores1
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return (Preco * Quantidade);
        }

        public void AdicionarQuantidadeEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutoEstoque(int remover)
        {
            Quantidade -= remover;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Preço: $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
