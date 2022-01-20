﻿using Course.Entities.Enums;

namespace Course.Entities
{
    class Rectangule : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangule(double width, double height, Color color): base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
