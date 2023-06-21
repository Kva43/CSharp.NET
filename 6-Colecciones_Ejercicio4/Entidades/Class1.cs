using System.Text;
using System;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;



        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)totalGoles / partidosJugados;
            return this.promedioGoles;
        }

        //LOS CONSTRUCTORES NO TIENEN INT, VOID
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
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

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dni: {this.dni.ToString()}");
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados.ToString()}");
            sb.AppendLine($"Total Goles: {this.totalGoles.ToString()}");
            sb.AppendLine($"Promedio Goles: {this.GetPromedioGoles().ToString()}");

            return sb.ToString();
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
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