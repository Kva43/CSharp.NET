using System;
namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int num1 = 10;
                    int num2 = 0;
                    // Código que puede generar una excepción
                    int result = num1 / num2; // Genera una excepción de división entre cero
                }
                catch (DivideByZeroException ex)
                {
                    throw new InvalidOperationException("Ocurrió un error al realizar la operación.", ex);
                }
            }
            catch (InvalidOperationException ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Excepción interna: " + ex.InnerException.Message);
                }
                else
                {
                    Console.WriteLine("Excepción: " + ex.Message);
                }
            }

        }

    }
}