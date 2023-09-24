namespace Biblioteca
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";

            while (numeroEntero > 0)
            {
                int residuo = numeroEntero % 2;
                binario = residuo.ToString() + binario;
                numeroEntero /= 2;
            }

            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroBinario)
        {
            int decimalValue = 0;
            int baseValue = 1;

            while (numeroBinario > 0)
            {
                int residuo = numeroBinario % 10;
                decimalValue += residuo * baseValue;
                numeroBinario /= 10;
                baseValue *= 2;
            }

            return decimalValue;
        }
    }
}