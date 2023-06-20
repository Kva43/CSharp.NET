//Ejercicio I01 - Máximo, mínimo y promedio
//Consigna
//Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular
//y mostrar: el valor máximo, el valor mínimo y el promedio.

//INFORMACIÓN
//Un escalar es una constante o variable que contiene un dato atómico y unidimensional.
//En contraposición al concepto de escalar, están los conceptos de array, lista y objeto,
//que pueden tener almacenado en su estructura más de un valor.​

namespace EjercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int varUno, varDos, varTres, varCuatro, varCinco;
            int valorMinimo;
            int valorMaximo;
            double promedio;

            Console.WriteLine("Ingrese el primer numero");
            Int32.TryParse(Console.ReadLine(), out varUno);

            Console.WriteLine("Ingrese el segundo numero");
            Int32.TryParse(Console.ReadLine(), out varDos);

            Console.WriteLine("Ingrese el tercer numero");
            Int32.TryParse(Console.ReadLine(), out varTres);

            Console.WriteLine("Ingrese el cuarto numero");
            Int32.TryParse(Console.ReadLine(), out varCuatro);

            Console.WriteLine("Ingrese el quinto numero");
            Int32.TryParse(Console.ReadLine(), out varCinco);

            valorMaximo = Math.Max(varUno, Math.Max(varDos, Math.Max(varTres, Math.Max(varCuatro, varCinco))));
            valorMinimo = Math.Min(varUno, Math.Min(varDos, Math.Min(varTres, Math.Min(varCuatro, varCinco))));
            promedio = (varUno + varDos + varTres + varCuatro + varCinco) / 5.0;

            Console.WriteLine("El valor máximo es: " + valorMaximo);
            Console.WriteLine("El valor mínimo es: " + valorMinimo);
            Console.WriteLine("El promedio es: " + promedio);


        }
    }
}