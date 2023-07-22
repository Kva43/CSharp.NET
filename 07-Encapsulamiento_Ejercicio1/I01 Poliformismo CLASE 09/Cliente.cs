namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero ,string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero { get { return numero; } }

        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.numero == b.numero;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}