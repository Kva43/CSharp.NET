//Suma de elementos: Dada una lista de enteros, calcula la suma de todos los elementos y muestra el resultado.
/*
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>() { 5, 10 ,15 , 20, 25 };

        int sumaEnteros = CalcularSuma(numeros);

        Console.WriteLine($"Cantidad de la suma es: {sumaEnteros}");
    }

    public static int CalcularSuma(List<int> listaEnteros)
    {
        int suma = 0;
        foreach(int numero in listaEnteros)
        {
            suma += numero;
        }
        return suma;
    }
}
*/
//Promedio de elementos: Dada una lista de enteros, calcula el promedio de todos los elementos y muestra el resultado.
/*
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>() { 5, 10, 15, 20, 25 };

        double promedio = CalcularPromedio(numeros);

        Console.WriteLine($"El promedio total es: {promedio}");
    }

    public static double CalcularPromedio(List<int> listaEnteros)
    {
        int suma = 0;
        double promedio;
        int contNumeros = 0;

        foreach (int numero in listaEnteros)
        {
            suma += numero;
            contNumeros++;
        }
        promedio = suma / contNumeros;
        return promedio;
    }
}
*/

//Orden ascendente: Dada una lista de cadenas, ordénala en orden ascendente y muestra los elementos ordenados.
/*
class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>() { "Zanahoria", "Poroto", "Calabaza", "Mani" };

        lista.Sort();
        foreach (string s in lista)
        {
            Console.WriteLine(s);
        }
    }
}
*/

//Eliminar duplicados: Dada una lista de enteros, elimina los elementos duplicados y muestra la lista resultante.
/*
class Program
{
    static void Main()
    {
        List<int> listaEnteros = new List<int>() { 5, 2, 8, 2, 5, 1, 8, 9, 10, 5 };
        List<int> listaSinDuplicados = EliminarDuplicados(listaEnteros);

        foreach (int entero in listaSinDuplicados)
        {
            Console.WriteLine(entero);
        }
    }

    static List<int> EliminarDuplicados(List<int> lista)
    {
        List<int> listaSinDuplicados = new List<int>();

        foreach (int elemento in lista)
        {
            if (!listaSinDuplicados.Contains(elemento))
            {
                listaSinDuplicados.Add(elemento);
            }
        }

        return listaSinDuplicados;
    }
}

class Program
{
    static void Main()
    {
        List<string> listaCadenas = new List<string>() { "perro", "gato", "perro", "elefante", "gato", "ratón" };
        List<string> listaSinDuplicados = EliminarDuplicados(listaCadenas);

        foreach (string cadena in listaSinDuplicados)
        {
            Console.WriteLine(cadena);
        }
    }

    static List<string> EliminarDuplicados(List<string> lista)
    {
        List<string> listaSinDuplicados = new List<string>();

        foreach (string elemento in lista)
        {
            if (!listaSinDuplicados.Contains(elemento))
            {
                listaSinDuplicados.Add(elemento);
            }
        }

        return listaSinDuplicados;
    }
}

class Program
{
    static void Main()
    {
        List<string> listaCadenas = new List<string>() { "perro", "gato", "perro", "elefante", "gato", "ratón" };
        List<string> listaSinDuplicados = EliminarDuplicados(listaCadenas);

        foreach (string cadena in listaSinDuplicados)
        {
            Console.WriteLine(cadena);
        }
    }

    static List<string> EliminarDuplicados(List<string> lista)
    {
        List<string> listaSinDuplicados = new List<string>();
        HashSet<string> set = new HashSet<string>();

        foreach (string elemento in lista)
        {
            if (!set.Contains(elemento))
            {
                listaSinDuplicados.Add(elemento);
                set.Add(elemento);
            }
        }

        return listaSinDuplicados;
    }
}
*/

//Buscar elemento máximo: Dada una lista de enteros, encuentra el elemento máximo y muéstralo.
/*
class Program
{
    static void Main()
    {
        List<int> listaEnteros = new List<int>() { 5, 2, 8, 21, 5, 1, 8, 9, 10, 5 };

        Console.WriteLine(HallarNumeroMayor(listaEnteros));
    }

    static int HallarNumeroMayor(List<int> lista)
    {
        int maximo = int.MinValue;

        foreach (int elemento in lista)
        {
            if(elemento > maximo)
            {
                maximo = elemento;
            }
        }
        return maximo;
    }
}

class Program
{
    static void Main()
    {
        List<int> listaEnteros = new List<int>() { 5, 2, 80, 12, 4, 9 };
        int maximo = listaEnteros.Max();

        Console.WriteLine("El elemento máximo es: " + maximo);
    }
}
*/

//Contar palabras: Dada una lista de cadenas que representan frases, cuenta cuántas palabras hay en total en todas las frases.
/*
class Program
{
    static void Main()
    {
        List<string> listaFrases = new List<string>()
        {
            "Hola, ¿cómo estás?",
            "Me gusta programar en C#",
            "El aprendizaje es continuo"
        };

        int totalPalabras = ContarPalabras(listaFrases);

        Console.WriteLine("El número total de palabras es: " + totalPalabras);
    }

    static int ContarPalabras(List<string> listaFrases)
    {
        int contador = 0;

        foreach (string frase in listaFrases)
        {
            string[] palabras = frase.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            contador += palabras.Length;
        }

        return contador;
    }
}
*/

//Diccionario de frecuencias: Dada una lista de elementos, crea un diccionario que muestre la frecuencia de cada elemento en la lista.
/*
class Program
{
    static void Main()
    {
        List<string> listaElementos = new List<string>()
        {
            "manzana", "naranja", "manzana", "pera", "naranja", "manzana"
        };

        Dictionary<string, int> frecuencias = CalcularFrecuencias(listaElementos);

        Console.WriteLine("Diccionario de Frecuencias:");
        foreach (var kvp in frecuencias)
        {
            Console.WriteLine($"Elemento: {kvp.Key}, Frecuencia: {kvp.Value}");
        }
    }

    static Dictionary<string, int> CalcularFrecuencias(List<string> lista)
    {
        Dictionary<string, int> frecuencias = new Dictionary<string, int>();

        foreach (string elemento in lista)
        {
            if (frecuencias.ContainsKey(elemento))
            {
                frecuencias[elemento]++;
            }
            else
            {
                frecuencias[elemento] = 1;
            }
        }

        return frecuencias;
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista1 = new List<int>() { 1, 2, 3 };
        List<int> lista2 = new List<int>() { 4, 5, 6 };

        List<int> listaResultante = lista1.Concat(lista2).ToList();

        Console.WriteLine("Lista Resultante:");
        foreach (int elemento in listaResultante)
        {
            Console.WriteLine(elemento);
        }
    }
}
