using System.Text;
using System;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados { get => partidosJugados; }
        public float PromedioGoles { get => (float)TotalGoles / PartidosJugados; }
        public int TotalGoles { get => totalGoles; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;

        }


        //retorna datos de un solo jugador
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Dni: {this.Dni.ToString()}");
            sb.AppendLine($"Partidos Jugados: {this.PartidosJugados.ToString()}");
            sb.AppendLine($"Total Goles: {this.TotalGoles.ToString()}");
            sb.AppendLine($"Promedio Goles: {this.PromedioGoles.ToString()}");

            return sb.ToString();
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

    }

    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count < e.cantidadDeJugadores) 
            {
                foreach(Jugador item in e.jugadores)
                {
                    if(item == j)
                    { 
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}