using System;
using Enumerações.Entities.Enums;

namespace Enumerações.Entities
{
    class Order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return id 
                +
                ", "
                +
                Moment
                +
                ", "
                +
                Status;
        }
    }
}
