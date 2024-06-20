using Entidades;

class Program
{
    static void Main(string[] args)
    {

        Equipo equipoTitular = new Equipo(3, "River");

        Jugador jugador1 = new Jugador(43239360, "Cristian", 9, 5);
        Jugador jugador2 = new Jugador(49452345, "Ariel", 1, 3);
        Jugador jugador3 = new Jugador(43239360, "Cristian", 9, 5);
        //42495394, "Caba", 110, 54

        if (equipoTitular + jugador1)
        {
            Console.WriteLine("Datos del jugador \n{0}", jugador1.MostrarDatos());
        }
        else
        {
            Console.WriteLine("NO SE AGREGO \n{0}", jugador1.MostrarDatos());
        }

        if (equipoTitular + jugador2)
        {
            Console.WriteLine("Datos del jugador \n{0}", jugador2.MostrarDatos());
        }
        else
        {
            Console.WriteLine("NO SE AGREGO \n{0}", jugador2.MostrarDatos());
        }

        if (equipoTitular + jugador3)
        {
            Console.WriteLine("Datos del jugador \n{0}", jugador3.MostrarDatos());
        }
        else
        {
            Console.WriteLine("NO SE AGREGO \n{0}", jugador3.MostrarDatos());
        }

    }
}