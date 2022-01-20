using Curso.Model.Entites;
using Curso.Model.Enums;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };

            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}
