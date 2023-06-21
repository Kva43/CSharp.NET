namespace VienenConSistemaDeAutoNavegacion
{
    public class Conductor
    {
        private string nombre;
        private int[] kilometros;

        public Conductor(string nombre, int[] kilometros)
        {
            this.nombre = nombre;
            this.kilometros = kilometros;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int[] Kilometros { get => kilometros; set => kilometros = value; }
    
        public int CalcularKilometrosSemanal()
        {
            int suma = 0;

            foreach(int km in kilometros)
            {
                suma += km;
            }
            return suma;
        }

        public static Conductor MayorRecorridoSemanal(Conductor[] arrayConductores)
        {
            int kmMax = 0;
            int kmDia;
            Conductor conductorMasRecorrido = null;

            foreach(Conductor conductor in arrayConductores)
            {
                kmDia = conductor.CalcularKilometrosSemanal();

                if(kmDia > kmMax)
                {
                    kmMax = kmDia;

                    conductorMasRecorrido = conductor;
                }
            }
            return conductorMasRecorrido;
        }
        
        public static Conductor MayorRecorridoDiaTres(Conductor[] arrayConductores)
        {
            int kmMax = 0;
            int kmDia;
            Conductor conductorMasRecorrido = null;

            foreach (Conductor conductor in arrayConductores)
            {
                kmDia = conductor.Kilometros[2];

                if (kmDia > kmMax)
                {
                    kmMax = kmDia;

                    conductorMasRecorrido = conductor;
                }
            }
            return conductorMasRecorrido;
        }

        public static Conductor MayorRecorridoDiaCinco(Conductor[] arrayConductores)
        {
            int kmMax = 0;
            int kmDia;
            Conductor conductorMasRecorrido = null;

            foreach (Conductor conductor in arrayConductores)
            {
                kmDia = conductor.Kilometros[4];

                if (kmDia > kmMax)
                {
                    kmMax = kmDia;

                    conductorMasRecorrido = conductor;
                }
            }
            return conductorMasRecorrido;
        }
    }
}