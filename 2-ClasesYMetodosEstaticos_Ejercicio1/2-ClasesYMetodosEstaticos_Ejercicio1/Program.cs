using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int minimo = -100;
        int maximo = 100;
        int cantidadNumeros = 10;

        for(int i = 0; i < cantidadNumeros; i++)
        {
            do
            {
                Console.WriteLine($"Ingrese el numero {i + 1}: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || !Validador.Validar(numero, minimo, maximo));
        }

    }
}