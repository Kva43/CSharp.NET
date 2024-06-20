using Biblioteca;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8, 2, VehiculoTerrestre.Colores.Azul, 5000);
            Automovil auto = new Automovil(4, 5, VehiculoTerrestre.Colores.Blanco, 3);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 1000);

            Console.WriteLine("Camion \n" +
                $"Cantidad Ruedas: {camion.CantidadRuedas} \n" +
                $"Cantidad Puertas: {camion.CantidadPuertas} \n" +
                $"Color: {camion.Color} \n" +
                $"Peso Carga {camion.PesoCarga}");


            Console.WriteLine("\nAuto \n" +
                $"Cantidad Ruedas: {auto.CantidadRuedas} \n" +
                $"Cantidad Puertas: {auto.CantidadPuertas} \n" +
                $"Color: {auto.Color} \n" +
                $"Cantidad Pasajeros: {auto.CantidadPasajeros}");


            Console.WriteLine("\nMoto \n" +
                $"Cantidad Ruedas: {moto.CantidadRuedas} \n" +
                $"Cantidad Puertas: {moto.CantidadPuertas} \n" +
                $"Color: {moto.Color} \n" +
                $"Cilindrada: {moto.Cilindradas}");
        }
    }
}
