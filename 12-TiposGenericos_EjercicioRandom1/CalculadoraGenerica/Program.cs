using Library;

class Program
{
    static void Main(string[] args)
    {
        Calculadora<int> calculadoraEnteros = new Calculadora<int>();
        int resultadoSuma = calculadoraEnteros.Sumar(5, 3); // resultadoSuma = 8

        Calculadora<double> calculadoraDecimales = new Calculadora<double>();
        double resultadoMultiplicacion = calculadoraDecimales.Multiplicar(2.5, 4.2); // resultadoMultiplicacion = 10.5

        Console.WriteLine("Resultado multiplicacion: {0}", resultadoMultiplicacion);
        Console.WriteLine("Resultado suma: {0}", resultadoSuma);

    }
}