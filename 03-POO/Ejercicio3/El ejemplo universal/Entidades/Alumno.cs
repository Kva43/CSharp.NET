using System.Text;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        public Alumno(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        private double CalcularPromedio(int notaUno, int notaDos)
        {
            return (notaUno + notaDos) / 2;
        }

        public double CalcularNotaFinal (int notaUno, int notaDos)
        {
            if (notaUno >= 4 && notaDos >= 4)
            {
                return random.Next(6, 10);
            }
            return -1;
        }

        public static string Mostrar(Alumno alumno)
        {
            StringBuilder sb = new StringBuilder();
            bool primerParcialRealizado = false;
            bool segudnoParcialRealizado = false;

            sb.AppendLine("Nombre: " + alumno.nombre);
            sb.AppendLine("Apellido: " + alumno.apellido);
            sb.AppendLine("Legajo: " + alumno.legajo);
            // si no realizo alguno de los parciales, el programa mostrará "NO REALIZADO"
            if(alumno.NotaPrimerParcial != 0)
            {
                sb.AppendLine("Nota primer parcial: " + alumno.NotaPrimerParcial.ToString());
                primerParcialRealizado = true;
            }
            else
            {
                sb.AppendLine("Nota primer parcial: NO REALIZADO");
            }
            if (alumno.NotaPrimerParcial != 0)
            {
                sb.AppendLine("Nota segundo parcial: " + alumno.NotaSegundoParcial.ToString());
                segudnoParcialRealizado = true;
            }
            else
            {
                sb.AppendLine("Nota segundo parcial: NO REALIZADO");
            }
            if(primerParcialRealizado == true && segudnoParcialRealizado == true)
            {
                sb.AppendLine("Promedio: " + alumno.CalcularPromedio(alumno.NotaPrimerParcial, alumno.NotaSegundoParcial).ToString());
            }
            else
            {
                sb.AppendLine("Promedio: DEBE UN PARCIAL");
            }

            if (alumno.CalcularNotaFinal(alumno.NotaPrimerParcial, alumno.NotaSegundoParcial) != -1)
            {
                sb.AppendLine("Nota Final: " + alumno.CalcularNotaFinal(alumno.NotaPrimerParcial, alumno.NotaSegundoParcial).ToString());
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}