using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        string nombre;
        string direccion;
        string genero;
        string pais;
        string[] cursos;
        int edad;

        public Ingresante(string nombre, string direccion, string genero, string pais, int edad, string[] cursos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Dirección: {direccion}");
            sb.AppendLine($"Género: {genero}");
            sb.AppendLine($"País: {pais}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Curso/s:");

            foreach (string curso in cursos)
            {
                sb.AppendLine(curso);
            }

            return sb.ToString();
        }
    }
}