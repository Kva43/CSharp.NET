using System.Text;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta >= 0)
            {
                this.tinta += tinta; // Correjir que no llene de más
            }
            else if (tinta <= cantidadTintaMaxima)
            {
                this.tinta -= tinta;
            }
        }

        void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            // Obtener el nivel de tinta actual del bolígrafo
            short tintaActual = GetTinta();

            // Calcular la tinta consumida por el gasto solicitado
            short tintaConsumida = (short)(gasto * 10);

            // Verificar si el gasto solicitado es mayor que la tinta disponible
            if (tintaConsumida > tintaActual)
            {
                // Si es mayor, utilizar toda la tinta disponible
                dibujo = new string('*', tintaActual / 10);
                // Establecer la tinta restante a cero
                SetTinta((short)(-tintaActual));
                // Indicar que no se pudo completar el dibujo
                return true;
            }
            else
            {
                // Si hay suficiente tinta para el gasto solicitado
                // Reducir el nivel de tinta por el gasto
                SetTinta((short)(-tintaConsumida));
                // Generar el dibujo con la cantidad de asteriscos correspondiente al gasto
                dibujo = new string('*', gasto);
                // Indicar que se pudo completar el dibujo
                return true;
            }
        }



    }
}