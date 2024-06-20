using Entidades;

class Program
{
    static void Main(string[] args)
    {
        Punto puntoUno = new Punto(2, 2);
        Punto puntoDos = new Punto(7, 8);
        Rectangulo rectanguloUno = new Rectangulo(puntoUno, puntoDos);

        Console.WriteLine("Perimetro: " + rectanguloUno.Perimetro);
        Console.WriteLine("Area: " + rectanguloUno.Area);
    }
}