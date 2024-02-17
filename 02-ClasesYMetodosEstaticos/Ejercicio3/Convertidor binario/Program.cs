using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //int valorInicial = 250;

        //string valorNuevo = Conversor.ConvertirDecimalABinario(valorInicial);

        //Console.WriteLine(valorNuevo);

        int nuevoDecimal = Conversor.ConvertirBinarioADecimal("11111010");
        Console.WriteLine($"El valor en decimal es {nuevoDecimal}");
    }
}

class Conversor
{

    // Forma número 1
    public static string ConvertirDecimalABinario(int numero)
    {
        // Manejar caso especial para el número 0
        if (numero == 0)
        {
            return "0";
        }

        // Almacenar los bits en un arreglo de caracteres
        char[] bits = new char[8];

        int indice = 7;  // Comenzar desde el bit más significativo

        // Iterar sobre los bits y construir la representación binaria
        while (numero != 0 && indice >= 0)
        {
            //bits[indice] = (numero % 2 == 1) ? '1' : '0'; ;
            if (numero % 2 == 0)
            {
                bits[indice] = '0';
            }
            else
            {
                bits[indice] = '1';
            }
            numero = numero / 2;
            indice--;
        }
        // Crear una cadena a partir del arreglo de caracteres
        return new string(bits, 0, 8);
    }



    // Forma número 3
    /*
    public static string ConvertirDecimalABinario(int numeroEntero)
    {
        // Utiliza el método integrado Convert.ToString con base 2 para convertir a binario
        string binario = Convert.ToString(numeroEntero, 2);
        return binario;
    }
    */



    // Forma número 2
    /*
    public static string ConvertirDecimalABinario(int numero)
    {
        // Manejar caso especial para el número 0
        if (numero == 0)
        {
            return "0";
        }

        // Almacenar los bits en un arreglo de caracteres
        char[] bits = new char[32];  // Suponiendo un entero de 32 bits (puedes ajustar según la arquitectura)

        int indice = 31;  // Comenzar desde el bit más significativo

        // Iterar sobre los bits y construir la representación binaria
        while (numero != 0 && indice >= 0)
        {
            // Obtener el bit actual y convertir a carácter
            bits[indice] = (numero & 1) == 1 ? '1' : '0';

            // Desplazar el número a la derecha
            numero >>= 1;

            // Mover al siguiente bit
            indice--;
        }

        // Crear una cadena a partir del arreglo de caracteres
        return new string(bits, indice + 1, 32 - (indice + 1));
    }
    */




    public static int ConvertirBinarioADecimal(string cadena)
    {
        //char[] bits = cadena.ToCharArray();

        char[] bits = new char[cadena.Length];

        bits = cadena.ToCharArray();
        Array.Reverse(bits);

        int suma = 0;

        for (int i = 0; i < cadena.Length; i++)
        {
            if(int.TryParse(bits[i].ToString(), out int numero))
            {
                if (numero == 1)
                {
                    suma = suma + (int)Math.Pow(2, i);
                }
            }
        }
        return suma;
    }

    //public static int ConvertirBinarioADecimal(int numeroBinario)
    //{
    //    int suma = 0;
    //    int posicion = 0;

    //    while (numeroBinario > 0)
    //    {
    //        int digito = numeroBinario % 10;
    //        suma += digito * (int)Math.Pow(2, posicion);
    //        numeroBinario /= 10;
    //        posicion++;
    //    }

    //    return suma;
    //}
}