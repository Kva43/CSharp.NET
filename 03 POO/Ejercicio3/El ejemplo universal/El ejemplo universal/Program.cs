using Entidades;
class Program
{
    static void Main(string[] args)
    {
        // Cargar 3 isntancias de alumnos

        Alumno alumnoUno = new Alumno("Cabanillas", "123", "Cristian");
        Alumno alumnoDos = new Alumno("Roman", "123", "Ariel");
        Alumno alumnoTres = new Alumno("Tuc", "123", "Anuel");
        // Pedir al usuario que suba las notas de los alumnos (la nota del final solo se podrá si regulizó la materia)

        Console.WriteLine(Alumno.Mostrar(alumnoUno)); 
    }
}