//Ejercicio I02 - ¿Vos cuántas primaveras tenés?
//Consigna
//Crear una aplicación de consola y una biblioteca de clases que contenga la clase
//Persona.
//Deberá tener los atributos:
//● nombre
//● fechaDeNacimiento
//● dni
//Deberá tener un constructor que inicialice todos los atributos.
//Construir los siguientes métodos para la clase:
//● Setter y getter para cada uno de los atributos.
//● CalcularEdad será privado y retornará la edad de la persona calculándola a
//partir de la fecha de nacimiento.

//● Mostrar retornará una cadena de texto con todos los datos de la persona,
//incluyendo la edad actual.
//● EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino
//devuelve “es menor”.
//1. Instanciar 3 objetos de tipo Persona en el método Main.
//2. Mostrar quiénes son mayores de edad y quiénes no.

using Entidades;

namespace Ejercicio2Clase3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Cristian", new DateTime(2001, 4, 28), 43239360);
            //Persona persona2 = new Persona("Noe", new DateTime(2008, 4, 8), 48934823);
            //Persona persona3 = new Persona("Juli", new DateTime(2017, 7, 21), 53342594);

            //InitPersona("Cristian", 28/04/2022, 43239360);
            //DateTime fecha = Caba.fechaDeNacimiento;
            //string fechaCorta = fecha.ToString("dd/MM/yyyy");
            //Console.WriteLine($"Mi nombre es {Caba.nombre}, nací el {fechaCorta} y mi documento es {Caba.dni}");


            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());


            //Console.WriteLine(persona2.Mostrar());
            //Console.WriteLine(persona2.EsMayorDeEdad());


            //Console.WriteLine(persona3.Mostrar());
            //Console.WriteLine(persona3.EsMayorDeEdad());



        }
    }
}