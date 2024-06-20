using Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        bool aplicacionActiva = true;
        string nombre;
        double cantidadDinero;
        Cuenta prueba = null;
        bool cuentaCreada = false;
        string mensajeCuentaNoCreada = "Debe crear una cuenta antes.";
        bool esNombreValido;

        while (aplicacionActiva)
        {
            Console.WriteLine("\n1. Crear cuenta\n2. Ingresar dinero\n3. Retirar dinero\n4. Información de mí cuenta");                                                        

            if ( int.TryParse(Console.ReadLine(), out int valor) && valor > 0 && valor < 5)
            {
                switch (valor)
                {
                    case 1:
                        if(cuentaCreada == false)
                        {
                            do
                            {
                                Console.WriteLine("Nombre: ");
                                nombre = Console.ReadLine();
                                esNombreValido = EsNombreValido(nombre);

                                if (!esNombreValido)
                                {
                                    Console.WriteLine("El nombre ingresado no es válido. Por favor, ingresa solo letras.\n");
                                }
                            } while (!esNombreValido);

                            do
                            {
                                Console.WriteLine("\nDeposito inicial: ");
                                string entradaUsuario = Console.ReadLine();

                                // Intentar convertir la entrada en un número y verificar si es válido
                                if (!double.TryParse(entradaUsuario, out cantidadDinero) || cantidadDinero <= 0)
                                {
                                    Console.WriteLine("Error. Ingrese un número positivo válido.");
                                    cantidadDinero = -1; // Establecer un valor inválido para garantizar que el bucle continúe
                                }

                            } while (cantidadDinero <= 0);

                            prueba = new Cuenta(nombre, cantidadDinero);
                            if (prueba != null)
                            {
                                cuentaCreada = true;
                                Console.WriteLine("\nLa cuenta ha sido creada.\n");
                            }
                        }
                        else { Console.WriteLine("Ya se creo una cuenta."); }

                        break;

                    case 2:
                        if(cuentaCreada)
                        {
                            do
                            {
                                Console.WriteLine("\nCantidad a ingresar: ");
                                string entradaUsuario = Console.ReadLine();

                                // Intentar convertir la entrada en un número y verificar si es válido
                                if (!double.TryParse(entradaUsuario, out cantidadDinero) || cantidadDinero <= 0)
                                {
                                    Console.WriteLine("Error. Ingrese un número positivo válido.");
                                    cantidadDinero = -1; // Establecer un valor inválido para garantizar que el bucle continúe
                                }
                                if(prueba.Ingresar(cantidadDinero))
                                {
                                    Console.WriteLine("Operación realizada con éxito.");
                                }

                            } while (cantidadDinero <= 0);
                        }
                        else { Console.WriteLine(mensajeCuentaNoCreada); }
                        break;

                    case 3:
                        if (cuentaCreada)
                        {
                            do
                            {
                                Console.WriteLine("\nCantidad a retirar: ");
                                string entradaUsuario = Console.ReadLine();

                                // Intentar convertir la entrada en un número y verificar si es válido
                                if (!double.TryParse(entradaUsuario, out cantidadDinero) || cantidadDinero <= 0)
                                {
                                    Console.WriteLine("Error. Ingrese un número positivo válido.");
                                    cantidadDinero = -1; // Establecer un valor inválido para garantizar que el bucle continúe
                                }
                                if(prueba.Retirar(cantidadDinero))
                                {
                                    Console.WriteLine("Operación realizada con éxito.");
                                }

                            } while (cantidadDinero <= 0);
                        }
                        else { Console.WriteLine(mensajeCuentaNoCreada); }
                        break;

                    case 4:
                        if (cuentaCreada)
                        {
                            Console.WriteLine(prueba.Mostrar());
                        }
                        else { Console.WriteLine(mensajeCuentaNoCreada); }
                        break;
                }
            }
            else { Console.WriteLine("Error. Ingrese un número válido.\n"); }

            Console.WriteLine("Presione Enter para realizar otro operacíon o cualquier otra para finalizar el programa.\n");

            aplicacionActiva = false;

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                aplicacionActiva = true;
            }
        }
    }

    static bool EsNombreValido (string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            return false;
        }

        foreach ( char c in nombre )
        {
            if ( !char.IsLetter (c) )
            {
                return false;
            }
        }
        return true;
    }
}