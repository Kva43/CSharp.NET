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
                double cuadrado = Math.Pow(numero, 2);
                double cubo = Math.Pow(numero, 3);

                Console.WriteLine($"El cuadrado del número {numero} es: {cuadrado}");
                Console.WriteLine($"El cubo del número {numero} es: {cubo}");

                numeroValido = true;
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}

