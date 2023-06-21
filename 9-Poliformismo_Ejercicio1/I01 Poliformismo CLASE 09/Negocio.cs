namespace Biblioteca
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        public Cliente Cliente
        { 
            get { return clientes.Dequeue(); } 
            set { _ = this + value; }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n,  Cliente c)
        {
            foreach(Cliente item in n.clientes)
            {
                if(item == c)                    //Contains no se usa acá porque usa el Equals, y puede ser que lo sobrecarguemos. Para evitar problemas no se usa.
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count(); }
        }
    }
}
