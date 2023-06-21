namespace ClassLibraryEjerc3Clase3
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        public ConsoleColor color;
        public short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }


        public ConsoleColor GetColor() { return this.color; }


        public short GetTinta() { return this.tinta; }


        private void SetTinta(short tinta)
        {
            if (tinta < 0) { this.tinta -= tinta; }
            else { this.tinta += tinta; }
        }




        




    }
}