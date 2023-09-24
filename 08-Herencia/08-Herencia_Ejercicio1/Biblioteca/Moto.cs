namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindradas;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindradas = cilindrada;
        }
    }
}
