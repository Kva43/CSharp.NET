using Entidades;

namespace Ejercicio2Clase3
{

    public class Program
    {
        static void Main(string[] args)
        {
            bool aplicacionActiva = false;

            DateTime fechaDeNacimiento;
            string nombre;
            int dni = 0;

            bool esNombreValido;
            bool esDniValido;

            bool formatoDeFechaNacimientoCorrecto = true;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                    esNombreValido = EsNombreValido(nombre);

                    if (!esNombreValido)
                    {
                        Console.WriteLine("El nombre ingresado no es válido. Por favor, ingresa solo letras.\n");
                    }
                } while (!esNombreValido);

                do
                {
                    Console.WriteLine("Ingrese su DNI: ");
                    string stringDni = Console.ReadLine();
                    esDniValido = EsNumeroValido(stringDni);

                    if (!esDniValido)
                    {
                        Console.WriteLine("El numero ingresado no es válido. Por favor, ingresa solo 8 numeros.(sin puntos).\n");
                    }
                    else
                    {
                        dni = int.Parse(stringDni);
                    }
                } while (!esDniValido);

                do
                {
                    Console.WriteLine("Ingrese su fecha de nacimiento (formato dd/MM/yyyy): ");

                    if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaDeNacimiento) && esDniValido)
                    {
                        Persona persona = new(nombre, fechaDeNacimiento, dni);
                        Console.WriteLine(persona.Mostrar());
                        Console.WriteLine(persona.EsMayorDeEdad());
                    }
                    else
                    {
                        Console.WriteLine("Formato de fecha inválido. Asegúrese de ingresar la fecha en el formato dd/MM/yyyy.");
                        formatoDeFechaNacimientoCorrecto = false;
                    }

                } while (!formatoDeFechaNacimientoCorrecto);

                Console.WriteLine("Presione Enter para continuar, o cualquier otra tecla para cerrar el programa.");

                if (Console.ReadKey().Key ==  ConsoleKey.Enter)
                {
                    aplicacionActiva = true;
                }
            } while (aplicacionActiva);
        }

        static bool EsNombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool EsNumeroValido(string stringNumero)
        {
            int cont = 0;
            if (string.IsNullOrWhiteSpace(stringNumero))
            {
                return false;
            }

            foreach (char c in stringNumero)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
                cont++;
            }

            if(!(cont == 8 ))
            {
                return false;
            }

            return true;
        }

    }

}