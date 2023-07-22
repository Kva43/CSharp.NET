namespace Biblioteca
{
    public abstract class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }

        public abstract void MostrarInformacion();
    }

}