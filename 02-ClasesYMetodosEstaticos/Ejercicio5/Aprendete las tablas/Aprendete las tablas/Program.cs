using System.Text;

class Program
{
    static void Main(string[] args)
    {
        bool aplicacionActiva = true;

        while (aplicacionActiva)
        {
            // pedir al usuario que ingrese un numero entero

            string tabla = GeneradorDeTablas(4);

            Console.WriteLine(tabla);
            Console.WriteLine("\nPresione Esc para salir o cualquier otra tecla para realizar otra tabla.");

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                aplicacionActiva = false;
            }
        }
    }





    // método estático que reciba un entero y devuelva un string
    public static string GeneradorDeTablas(double numero)
    {
        StringBuilder sb = new StringBuilder();

        if (!double.IsNaN(numero))
        {
            sb.AppendLine($"Tabla de multiplicar del número {numero}:");
            sb.AppendLine($"{numero} x 1 = {numero * 1}");
            sb.AppendLine($"{numero} x 2 = {numero * 2}");
            sb.AppendLine($"{numero} x 3 = {numero * 3}");
            sb.AppendLine($"{numero} x 4 = {numero * 4}");
            sb.AppendLine($"{numero} x 5 = {numero * 5}");
            sb.AppendLine($"{numero} x 6 = {numero * 6}");
            sb.AppendLine($"{numero} x 7 = {numero * 7}");
            sb.AppendLine($"{numero} x 8 = {numero * 8}");
            sb.AppendLine($"{numero} x 9 = {numero * 9}");
        }
        return sb.ToString();
    }
}



