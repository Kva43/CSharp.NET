using Entidades;

class Program
{
    static void Main(string[] args)
    {
        bool aplicacionActiva = true;

        while (aplicacionActiva)
        {
            Console.Write("Ingrese el primer número: ");
            double numero1;
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada no válida. Ingrese un número válido: ");
                Console.ResetColor();
            }

            Console.Write("Ingrese el segundo número: ");
            double numero2;
            while (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada no válida. Ingrese un número válido: ");
                Console.ResetColor();
            }

            // Solicitar al usuario que ingrese la operación
            Console.Write("Ingrese la operación (+, -, *, /): ");
            char operacion;
            while (!char.TryParse(Console.ReadLine(), out operacion) || (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/'))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada no válida. Ingrese una operación válida (+, -, *, /): ");
                Console.ResetColor();
            }

            double resultado = Calculadora.Calcular(numero1, numero2, operacion);

            // if (resultado != double.NaN)         forma incorrecta de verificar
            if (!double.IsNaN(resultado))
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"El resultado de {numero1} {operacion} {numero2} es: {resultado}");
            
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Error en la operación elegida o en los parámetros.");

                Console.ResetColor();
            }

            Console.WriteLine("\nPresione Esc para salir o cualquier otra tecla para realizar otra operación.");

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                aplicacionActiva = false;
            }

        }
    }
}