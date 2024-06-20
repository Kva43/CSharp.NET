namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        short pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short pesoCarga) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
        }

        public int PesoCarga { get => pesoCarga; }
    }
}
