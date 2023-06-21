
/*
Ejercicio A01 - Calcular un factorial

Consigna
El factorial de un número es una operación que consiste en multiplicar un número “n”
por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial
de 3 es el resultado de multiplicar 3 por 2 por 1.
En una aplicación de consola, desarrollar un método estático que calcule el factorial de
un número dado.
*/

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

/*
Ejercicio I05 - Aprendete las tablas

Consigna
Crear una aplicación de consola que permita al usuario ingresar un número entero.
Desarrollar un método estático que reciba un número y devuelva la tabla de
multiplicación de ese número en formato string.
Se deberá utilizar la clase StringBuilder combinada con strings interpolados para
armar el resultado.
Mostrar en la consola el resultado.
Por ejemplo, si se ingresa el número 2 la salida deberá ser:
Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18
*/



/*
Ejercicio I06 - Calculadora de áreas

Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase
(estáticos) que realicen el cálculo del área que corresponda:
public double CalcularAreaCuadrado(double longitudLado) { }
public double CalcularAreaTriangulo(double base, double altura) { }

public double CalcularAreaCirculo(double radio) { }
El ingreso de los datos como la visualización se deberán realizar desde el método
Main().
*/





/*
Ejercicio I07 - Pitágoras estaría orgulloso

Consigna
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un
triángulo en centímetros.
El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de
pitágoras y
Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
Mostrar el resultado en la consola.
*/





/*
Ejercicio I08 - El tiempo pasa...

Consigna
Crear un método estático que reciba una fecha y calcule el número de días que pasaron
desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el
número de días vividos por esa persona hasta la fecha actual utilizando el método
desarrollado anteriormente.
Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
*/