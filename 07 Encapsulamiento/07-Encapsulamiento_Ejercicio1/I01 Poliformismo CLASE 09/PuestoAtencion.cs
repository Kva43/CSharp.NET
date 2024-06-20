using System.Threading;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        static int numeroActual;
        Puesto puesto;

        public enum Puesto
        {
            Caja1 = 1, Caja2 = 2
        }

        public static int NumeroActual
        {
            //get { return numeroActual++; }    si pongo el '++' despues de la var, primero me retorna el valor después lo incrementa
            get { return ++numeroActual; }      //si lo pongo adelante, primero incrementa y luego retorna
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            if(cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            else { return false; }
        }
    }
}
