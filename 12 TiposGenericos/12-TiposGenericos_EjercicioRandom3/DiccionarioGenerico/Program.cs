using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Diccionario<string, int> miDiccionario = new Diccionario<string, int>();
        miDiccionario.Agregar("uno", 1);
        miDiccionario.Agregar("dos", 2);

        bool contieneClave = miDiccionario.ContieneClave("uno");
        Console.WriteLine("El diccionario contiene la clave 'uno': " + contieneClave);

        bool contieneValor = miDiccionario.ContieneValor(2);
        Console.WriteLine("El diccionario contiene el valor '2': " + contieneValor);

        int valor = miDiccionario.ObtenerValor("dos");
        Console.WriteLine("El valor asociado a la clave 'dos' es: " + valor);

        int cantidadElementos = miDiccionario.ContarElementos();
        Console.WriteLine("La cantidad de elementos en el diccionario es: " + cantidadElementos);

    }
}