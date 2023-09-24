using System;
class Program
{
    static void Main(string[] args)
    {
        bool numeroValido = false;

        while (!numeroValido)
        {
            Console.WriteLine("Ingrese un número: ");

            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
            {
                Console.WriteLine($"El cuadrado del número {numero} es: {Math.Pow(numero, 2)}");
                Console.WriteLine($"El cubo del número {numero} es: {Math.Pow(numero, 3)}");
                numeroValido = true;
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}

