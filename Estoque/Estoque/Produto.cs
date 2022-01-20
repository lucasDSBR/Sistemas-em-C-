using System.Globalization;

namespace Estoque
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set}
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
                + _nome 
                + ", Preço: $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
