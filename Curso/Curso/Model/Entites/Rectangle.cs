using System.Globalization;

namespace Curso.Model.Entites
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", Width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", Height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

