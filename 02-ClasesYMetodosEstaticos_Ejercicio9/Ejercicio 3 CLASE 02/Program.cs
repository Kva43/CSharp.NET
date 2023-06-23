
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = CalcularFactorial(num);

        Console.WriteLine($"El factorial de {num} es {resultado}");
        Console.ReadKey();
    }

    static int CalcularFactorial(int num)
    {
        int factorial = 1;

        for (int i = num; i > 0; i--)
        {
            factorial *= i;
        }

        return factorial;
    }
}
