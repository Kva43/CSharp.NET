﻿namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}