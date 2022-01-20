using System;
using System.Globalization;
using CaixaCliente.Entities.Enum;
using CaixaCliente.Entities;

namespace CaixaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio do processo para coletar os dados
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            //Armazenando o nome do cliente uma string
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            //Armazenando o email do cliente em uma String
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            //Coletando a data informada e transfomando-a no tipo data:
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            //Recebendo o status pelo cliente:
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            

            //Criando uma nova instancia "cliente" e inserindo os dados referentes ao cliente
            Client client = new Client(clientName, email, birthDate);

            //Criando uma nova instrancia de Pedidos e inserindo o status, a data e o cliente naquele pedido
            Order order = new Order(DateTime.Now, status, client);

            //Pegando o total de itens em tal pedido
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            //Iniciando escopo para pegar os produtos:
            for (int i = 1; i <= n; i++)
            {
                //COMEÇANDO A COLETAR OS DADOS REFERENTES AOS ITENS
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                //Criando uma nova instancia de produtos e inserindo os valores
                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}