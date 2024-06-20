namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public int CantidadPasajeros { get =>  cantidadPasajeros; }
    }
}