using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        string titular;
        double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; }
        public double Cantidad { get => cantidad; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {Titular}");
            sb.AppendLine($"Cantidad: {Cantidad}");

            return sb.ToString();
        }

        public bool Ingresar(double monto)
        {
            bool valido = true;

            if(monto < 0 )
            {
                valido = false;
            }
            else
            {
                cantidad += monto;
            }
            return valido;
        }

        public bool Retirar(double monto)
        {
            bool valido = true;

            if (monto < 0)
            {
                valido = false;
            }
            else
            {
                cantidad -= monto;
            }
            return valido;
        }
    }
}