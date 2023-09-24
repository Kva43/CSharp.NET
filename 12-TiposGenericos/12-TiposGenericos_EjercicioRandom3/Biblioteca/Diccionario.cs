namespace Biblioteca
{
    public class Diccionario<TKey, TValue>
    {
        private Dictionary<TKey, TValue> elementos;

        public Diccionario()
        {
            elementos = new Dictionary<TKey, TValue>();
        }

        public void Agregar(TKey clave, TValue valor)
        {
            elementos.Add(clave, valor);
        }

        public bool ContieneClave(TKey clave)
        {
            return elementos.ContainsKey(clave);
        }

        public bool ContieneValor(TValue valor)
        {
            return elementos.ContainsValue(valor);
        }

        public TValue ObtenerValor(TKey clave)
        {
            if(elementos.TryGetValue(clave, out TValue valor))
            {
                return valor;
            }
            throw new KeyNotFoundException("La clave especificada no existe en el diccionario.");
        }

        public int ContarElementos()
        {
            return elementos.Count;
        }
    }

}