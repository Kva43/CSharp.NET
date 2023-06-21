﻿using System;
using Biblioteca;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camioncito = new Camion(8, 2, Colores.Azul, 3, 5000);
            System.Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.cantidadRuedas, camioncito.cantidadPuertas, camioncito.color, camioncito.cantidadMarchas, camioncito.pesoCarga);
            System.Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, Colores.Blanco, 3, 3);
            System.Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantidadRuedas, autito.cantidadPuertas, autito.color, autito.cantidadMarchas, autito.cantidadPasajeros);
            System.Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, Colores.Rojo, 1000);
            System.Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantidadRuedas, motito.cantidadPuertas, motito.color, motito.cilindradas);

        }
    }
}