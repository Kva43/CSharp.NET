namespace Entidades
{
    public static class CalculadoraDeArea
    {
        const double pi = 3.141592;

        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double baseT, double altura) 
        {
            return  (baseT * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return (radio * radio) * pi;
        }
    }
}