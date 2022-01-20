using Curso.Model.Enums;

namespace Curso.Model.Entites
{
    abstract class AbstractShape: IShape
    {
        public Color MyProperty { get; set; }

        public abstract double Area();
    }
}
