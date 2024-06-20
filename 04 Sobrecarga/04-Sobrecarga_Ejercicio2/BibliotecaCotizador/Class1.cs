namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 102.65;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //SUMA PESO PESO
        public static Pesos operator +(Pesos pesos, Pesos pesos2)
        {
            double cantidadEnPesos = pesos.GetCantidad() + pesos2.GetCantidad();
            return new Pesos(cantidadEnPesos);
        }
        //RESTA PESO PESO
        public static Pesos operator -(Pesos pesos, Pesos pesos2)
        {
            double cantidadEnPesos = pesos.GetCantidad() - pesos2.GetCantidad();
            return new Pesos(cantidadEnPesos);
        }

        public static Pesos operator +(Pesos pesos, Dolar dolar)
        {
            double cantidadEnPesos = pesos.GetCantidad() + (dolar.GetCantidad() * Dolar.GetCotizacion());
            return new Pesos(cantidadEnPesos);
        }

        public static Pesos operator +(Pesos pesos, Euro euro)
        {
            double cantidadEnPesos = pesos.GetCantidad() + (euro.GetCantidad() * Euro.GetCotizacion() * Dolar.GetCotizacion());
            return new Pesos(cantidadEnPesos);
        }

        public static Pesos operator -(Pesos pesos, Dolar dolar)
        {
            double cantidadEnPesos = pesos.GetCantidad() - (dolar.GetCantidad() * Dolar.GetCotizacion());
            return new Pesos(cantidadEnPesos);
        }

        public static Pesos operator -(Pesos pesos, Euro euro)
        {
            double cantidadEnPesos = pesos.GetCantidad() - (euro.GetCantidad() * Euro.GetCotizacion() * Dolar.GetCotizacion());
            return new Pesos(cantidadEnPesos);
        }

        public static bool operator ==(Pesos pesos1, Pesos pesos2)
        {
            return pesos1.GetCantidad() == pesos2.GetCantidad();
        }

        public static bool operator !=(Pesos pesos1, Pesos pesos2)
        {
            return pesos1.GetCantidad() != pesos2.GetCantidad();
        }


    }

    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        //SUMA EURO + EURO
        public static Euro operator +(Euro euro, Euro euro2)
        {
            double cantidadEnEuros = euro.GetCantidad() + euro2.GetCantidad();
            return new Euro(cantidadEnEuros);
        }


        public static Euro operator +(Euro euro, Dolar dolar)
        {
            double cantidadEnEuros = euro.GetCantidad() + (dolar.GetCantidad() / Dolar.GetCotizacion());
            return new Euro(cantidadEnEuros);
        }

        public static Euro operator +(Euro euro, Pesos pesos)
        {
            double cantidadEnEuros = euro.GetCantidad() + (pesos.GetCantidad() / (Euro.GetCotizacion() * Dolar.GetCotizacion()));
            return new Euro(cantidadEnEuros);
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            double cantidadEnEuros = euro.GetCantidad() - (dolar.GetCantidad() / Dolar.GetCotizacion());
            return new Euro(cantidadEnEuros);
        }

        public static Euro operator -(Euro euro, Pesos pesos)
        {
            double cantidadEnEuros = euro.GetCantidad() - (pesos.GetCantidad() / (Euro.GetCotizacion() * Dolar.GetCotizacion()));
            return new Euro(cantidadEnEuros);
        }

        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return euro1.GetCantidad() == euro2.GetCantidad();
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return euro1.GetCantidad() != euro2.GetCantidad();
        }

    }

    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //SUMA DOLAR DOLAR
        public static Dolar operator +(Dolar dolar, Dolar dolar2)
        {
            double cantidadEnDolares = dolar.GetCantidad() + dolar2.GetCantidad();
            return new Dolar(cantidadEnDolares);
        }
        
        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {
            double cantidadEnDolares = dolar.GetCantidad() + (pesos.GetCantidad() / Dolar.GetCotizacion());
            return new Dolar(cantidadEnDolares);
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            double cantidadEnDolares = dolar.GetCantidad() + (euro.GetCantidad() * Euro.GetCotizacion());
            return new Dolar(cantidadEnDolares);
        }

        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {
            double cantidadEnDolares = dolar.GetCantidad() - (pesos.GetCantidad() / Dolar.GetCotizacion());
            return new Dolar(cantidadEnDolares);
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            double cantidadEnDolares = dolar.GetCantidad() - (euro.GetCantidad() * Euro.GetCotizacion());
            return new Dolar(cantidadEnDolares);
        }

        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return dolar1.GetCantidad() == dolar2.GetCantidad();
        }

        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return dolar1.GetCantidad() != dolar2.GetCantidad();
        }


    }


}