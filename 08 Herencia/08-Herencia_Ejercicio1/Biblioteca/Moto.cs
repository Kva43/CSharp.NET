namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        short cilindradas;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindradas = cilindrada;
        }

        public short Cilindradas { get => this.cilindradas; }
    }
}
