using System;
using Billetes;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesos pesos1 = new Pesos(5000);
            Euro euro1 = new Euro(50);
            Dolar dolar1 = new Dolar(100);

            Pesos pesos2 = new Pesos(2000);
            Euro euro2 = new Euro(25);
            Dolar dolar2 = new Dolar(50);

            // Prueba de suma
            Pesos sumaPesos = pesos1 + pesos2;
            Euro sumaEuro = euro1 + euro2;
            Dolar sumaDolar = dolar1 + dolar2;

            Console.WriteLine($"Suma en pesos: {sumaPesos.GetCantidad()}");
            Console.WriteLine($"Suma en euros: {sumaEuro.GetCantidad()}");
            Console.WriteLine($"Suma en dólares: {sumaDolar.GetCantidad()}");

            // Prueba de resta
            Pesos restaPesos = pesos1 - pesos2;
            //Euro restaEuro = euro1 - euro2;
            //Dolar restaDolar = dolar1 - dolar2;

            Console.WriteLine($"Resta en pesos: {restaPesos.GetCantidad()}");
            //Console.WriteLine($"Resta en euros: {restaEuro.GetCantidad()}");

            Dolar sumaDolarEuro = dolar1 + euro1;
            Console.WriteLine($"Suma en dolares de {dolar1.GetCantidad()} + {euro1.GetCantidad()} es: {sumaDolarEuro.GetCantidad()}");

            bool sonIguales = dolar1 == dolar2;
            Console.WriteLine($"Son iguales {dolar1.GetCantidad()} dolares y {dolar2.GetCantidad()} dolares? -> {sonIguales} ");


        }
    }
}
        
