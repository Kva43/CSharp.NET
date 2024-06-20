namespace Entidades
{
    public class Conductor
    {
        private string nombre;
        private float[] kilometrosSemanales;

        public Conductor(string nombre, float[] kilometrosSemanales)
        {
            this.nombre = nombre;
            this.kilometrosSemanales = kilometrosSemanales;
        }

        public float[] KilometrosQueHizoSemana { get => kilometrosSemanales; }
        public string Nombre { get => nombre; }






        /// <summary>
        ///     Recibe una array de Conductor. Cada Conductor tiene un array de float que representa los kilometros que hizo en una semana. Este método retorna
        ///     el que mayor kilometros recorrió semanalmente.
        /// </summary>
        /// <param name="conductores"></param>
        /// <returns></returns>
        public static Conductor ConductorMayorRecorridoSemanal(Conductor[] conductores)
        {
            float kmTotalesDeCadaConductor = 0;
            float[] arrayKmTotalesDeCadaConductor = new float[conductores.Length];
            int cont = 0;
            Conductor conductorMayorRecorrido = null;

            foreach (Conductor conductor in conductores)
            {
                for (int i = 0; i < conductor.KilometrosQueHizoSemana.Length; i++)
                {
                    kmTotalesDeCadaConductor += conductor.KilometrosQueHizoSemana[i];
                }
                arrayKmTotalesDeCadaConductor[cont] = kmTotalesDeCadaConductor;
                cont++;
                kmTotalesDeCadaConductor = 0;
            }
            float valorMasAlto = ObtenerValorMasAlto(arrayKmTotalesDeCadaConductor);

            for (int i = 0; i < arrayKmTotalesDeCadaConductor.Length; i++)
            {
                if(arrayKmTotalesDeCadaConductor[i] == valorMasAlto)
                {
                    conductorMayorRecorrido = conductores[i];
                    return conductorMayorRecorrido;
                }
            }
            return conductorMayorRecorrido;
        }

        static float ObtenerValorMasAlto(float[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("El array no puede ser nulo o vacío.");
            }

            float maximo = array[0];

            foreach (float num in array)
            {
                if (num > maximo)
                {
                    maximo = num;
                }
            }

            return maximo;
        }



        public static Conductor ConductorMayorRecorridoSegunDia(Conductor[] conductores, int dia)
        {
            float[] kmDiaConductor = new float[conductores.Length];
            int cont = 0;
            Conductor conductorMayorRecorrido = null;
            Conductor conductorNull = null;

            foreach (Conductor conductor in conductores)
            {
                if (conductor.KilometrosQueHizoSemana.Length > dia)
                {
                    kmDiaConductor[cont] = conductor.KilometrosQueHizoSemana[dia];
                    cont++;
                }
                else
                {
                    kmDiaConductor[cont] = 0;
                    cont++;
                }
            }
            float valorMasAlto = ObtenerValorMasAlto(kmDiaConductor);

            for (int i = 0; i < kmDiaConductor.Length; i++)
            {
                if (kmDiaConductor[i] == valorMasAlto)
                {
                    conductorMayorRecorrido = conductores[i];
                    return conductorMayorRecorrido;
                }
            }
            return conductorMayorRecorrido;
        }

        // hacer una función que verifique si por lo menos un Conductor trabajo el día 3 o 5 (leer enunciado ejercicio). Y retornará ese conductor porque será el único.
    }
}