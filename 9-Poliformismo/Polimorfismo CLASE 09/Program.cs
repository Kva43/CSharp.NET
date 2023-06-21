using Entidades;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Animal perro = new Perro();
        Animal gato = new Gato();

        Console.WriteLine($"Animal: {animal.EmitirSonido()}");
        Console.WriteLine($"Perro: {perro.EmitirSonido()}");
        Console.WriteLine($"Gato: {gato.EmitirSonido()}");
    }
}