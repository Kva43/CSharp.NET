
/*
Ejercicio I04 - La calculadora

Consigna
Realizar un programa que permita realizar operaciones matemáticas simples (suma,
resta, multiplicación y división).
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando
y la operación matemática. El método devolverá el resultado de la operación.
Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true
si el operando es distinto de cero.
Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
(ingresando el caracter +, -, * o /).
El usuario decidirá cuándo finalizar el programa.
*/
using EjercicioCuatro;

class Program
{
    static void Main(string[] args)
    {
        double valor1, valor2;
        char operando;
        bool salir = false;

        while (!salir)
        {

            Console.WriteLine("Ingrese el primer operando: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo operando: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion ( + - * / ): ");
            operando = char.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: {0}", Calculadora.Calcular(valor1, valor2, operando));

            Console.Write("¿Desea salir? (s/n): ");
            char respuesta = char.Parse(Console.ReadLine());

            if (respuesta == 's' || respuesta == 'S')
            {
                salir = true;
            }
        }
    }
}
