using System.Threading.Channels;

namespace Entidades
{
    public class Rectangulo
    {
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        int baseRectangulo;
        int alturaRectangulo;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            baseRectangulo = Math.Abs(vertice3.GetX - vertice1.GetX);
            alturaRectangulo = Math.Abs(vertice3.GetY - vertice1.GetY);

            vertice2 = new Punto(vertice1.GetY, vertice1.GetX + baseRectangulo);
            vertice4 = new Punto(vertice3.GetY, vertice1.GetX);
        }

        public float Perimetro { get => (baseRectangulo * alturaRectangulo) / 2; }
        public float Area { get => baseRectangulo * alturaRectangulo; }
    }
}