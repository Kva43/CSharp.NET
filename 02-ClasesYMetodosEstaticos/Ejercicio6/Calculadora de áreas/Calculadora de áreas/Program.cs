using Entidades;

class Program
{
    static void Main(string[] args)
    {
        double areaCuadrado;
        double areaTriangulo;
        double areaCirculo;

        areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(10);

        Console.WriteLine($"Área del cuadrado: {areaCuadrado}");

        areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(10, 5);

        Console.WriteLine($"Área del triángulo: {areaTriangulo}");

        areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(10);

        Console.WriteLine($"Área del circulo: {areaCirculo}");
    }
}