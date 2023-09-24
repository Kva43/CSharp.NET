using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        ListaOrdenada<int> listaEnteros = new ListaOrdenada<int>();
        listaEnteros.Agregar(5);
        listaEnteros.Agregar(10);
        bool contieneElemento = listaEnteros.Contiene(5); // contieneElemento = true
        int cantidadElementos = listaEnteros.ContarElementos(); // cantidadElementos = 2

        Console.WriteLine($"cantidad elementos: {cantidadElementos}");

        ListaOrdenada<string> listaStrings = new ListaOrdenada<string>();
        listaStrings.Agregar("Hola");
        listaStrings.Agregar("Mundo");
        listaStrings.Eliminar("Hola");
        cantidadElementos = listaStrings.ContarElementos(); // cantidadElementos = 1

        Console.WriteLine($"cantidad elementos: {cantidadElementos}");
    }
}