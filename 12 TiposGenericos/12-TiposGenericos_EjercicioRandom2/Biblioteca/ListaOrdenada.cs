namespace Biblioteca
{
    public class ListaOrdenada<T> where T : IComparable<T>
    {
        private List<T> elementos;

        public ListaOrdenada()
        {
            elementos = new List<T>();
        }

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
            elementos.Sort();
        }

        public bool Contiene(T elemento)
        {
            return elementos.Contains(elemento);
        }

        public void Eliminar(T elemento)
        {
            elementos.Remove(elemento);
        }

        public int ContarElementos()
        {
            return elementos.Count;
        }
    }

}