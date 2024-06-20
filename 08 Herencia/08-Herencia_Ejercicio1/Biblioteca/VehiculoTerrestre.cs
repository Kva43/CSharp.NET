namespace Biblioteca
{
    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public short CantidadRuedas { get => cantidadRuedas; }
        public short CantidadPuertas { get => cantidadPuertas; }
        public Colores Color { get => color; }


        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }
    }

}
