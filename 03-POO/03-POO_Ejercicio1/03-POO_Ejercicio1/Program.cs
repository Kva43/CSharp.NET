using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Cuenta prueba = new Cuenta("Cabanillas", 100);

        Console.WriteLine(prueba.Mostrar());

        prueba.Retirar(101);
        Console.WriteLine(prueba.Mostrar());

        prueba.Ingresar(1000);
        Console.WriteLine(prueba.Mostrar());
    }
}