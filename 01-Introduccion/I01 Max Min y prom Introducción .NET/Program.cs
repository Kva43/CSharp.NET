using System;

namespace I01_Max_Min_y_prom_Introducción_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int variableUno, variableDos, variableTres, variableCuatro;
            int max = int.MinValue;
            int min = int.MaxValue;
            float prom;

            Console.WriteLine("Ingrese el primer numero: ");
            variableUno = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            variableDos = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            variableTres = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero: ");
            variableCuatro = Int32.Parse(Console.ReadLine());

            

            if(variableUno > max)
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
}