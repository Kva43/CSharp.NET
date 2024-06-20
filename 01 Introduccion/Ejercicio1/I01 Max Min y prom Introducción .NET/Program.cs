//Ejercicio resuelto con variables escalares
//Exercise solved with scalar variables

/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        float prom;

        Console.WriteLine("Ingrese el primer numero: ");
        Int32.TryParse(Console.ReadLine(), out int variableUno);

        Console.WriteLine("Ingrese el segundo numero: ");
        Int32.TryParse(Console.ReadLine(), out int variableDos);

        Console.WriteLine("Ingrese el tercer numero: ");
        Int32.TryParse(Console.ReadLine(), out int variableTres);

        Console.WriteLine("Ingrese el cuarto numero: ");
        Int32.TryParse(Console.ReadLine(), out int variableCuatro);

        if (variableUno > max)
        {
            max = variableUno;
        }

        if (variableUno < min)
        {
            min = variableUno;
        }

        if (variableDos > max)
        {
            max = variableDos;
        }

        if (variableDos < min)
        {
            min = variableDos;
        }

        if (variableTres > max)
        {
            max = variableTres;
        }

        if (variableTres < min)
        {
            min = variableTres;
        }

        if (variableCuatro > max)
        {
            max = variableCuatro;
        }

        if (variableCuatro < min)
        {
            min = variableCuatro;
        }

        prom = (float)(variableUno + variableDos + variableTres + variableCuatro) / 4;

        Console.WriteLine($"\nEl menor numero ingresado fue: {min} y el mayor: {max}");
        Console.WriteLine($"\nPromedio: {prom}");

        Console.ReadLine();
    }
}
*/



//Ejercicio resuelto con variables NO escalares
//Exercise solved with NON-scalar variables

using System;

class Program
{
    static void Main(string[] args)
    {
        const int numCount = 4;
        int[] numeros = new int[numCount];
        int max = int.MinValue;
        int min = int.MaxValue;
        float prom;
        int sumaDeEnteros = 0;

        for (int i = 0; i < numCount; i++)
        {
            Console.WriteLine($"Ingrese el {i + 1}° número: ");
            if (int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                max = Math.Max(max, numeros[i]);
                min = Math.Min(min, numeros[i]);
                sumaDeEnteros += numeros[i];
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número válido.");
                i--; //Repite la iteración para ingresar un número válido.
            }
        }

        prom = (float)sumaDeEnteros / numCount;

        Console.WriteLine($"\nEl menor número ingresado fue: {min} y el mayor: {max}");
        Console.WriteLine($"\nY el promedio es: {prom}");
    }
}
