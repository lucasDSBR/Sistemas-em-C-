using Course.Entities.Enums;
using System;
namespace Course.Entities
{
    class Circle : Shape
    {
        public double Redius { get; set; }

        public Circle(double redius, Color color) : base(color)
        {

            Redius = redius;
        }

        public override double Area()
        {
            return Math.PI * (Redius * Redius);
        }


    }
}
