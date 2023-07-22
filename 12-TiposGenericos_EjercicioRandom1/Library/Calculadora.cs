namespace Library
{
    public class Calculadora<T>
    {
        public T Sumar(T a, T b)
        {
            dynamic valorA = a;
            dynamic valorB = b;
            return valorA + valorB;
        }

        public T Restar(T a, T b)
        {
            dynamic valorA = a;
            dynamic valorB = b;
            return valorA - valorB;
        }

        public T Multiplicar(T a, T b)
        {
            dynamic valorA = a;
            dynamic valorB = b;
            return valorA * valorB;
        }

        public T Dividir(T a, T b)
        {
            dynamic valorA = a;
            dynamic valorB = b;
            return valorA / valorB;
        }
    }

}