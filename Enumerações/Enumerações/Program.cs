using Enumerações.Entities;
using Enumerações.Entities.Enums;
using System;

namespace Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {   
                id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };


            Console.WriteLine(order);

            //Convertendo String para Enum:
            string txt = OrderStatus.PendingPayment.ToString();
            //Convertendo Enum para String:
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
