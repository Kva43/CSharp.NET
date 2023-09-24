using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        int decimalNumber = 25;
        string binaryNumber = Conversor.ConvertirDecimalABinario(decimalNumber);
        Console.WriteLine($"El número binario equivalente a {decimalNumber} es: {binaryNumber}");

        int binarioNumero = 11001;
        int decimalNumero = Conversor.ConvertirBinarioADecimal(binarioNumero);
        Console.WriteLine($"El número decimal equivalente a {binarioNumero} es: {decimalNumero}");

    }
}