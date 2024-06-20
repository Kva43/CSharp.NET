namespace Entidades
{
    public static class Calculadora
    {
        public static double Calcular(double parametroUno, double parametroDos, char operacion)
        {
            if ( operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/') 
            {
                switch (operacion)
                {
                    case '+':
                        return parametroUno + parametroDos;

                    case '-':
                        return parametroUno - parametroDos;
                    
                    case '*':
                        return parametroUno * parametroDos;
                    
                    case '/':
                        if ( Validar(parametroDos) == true )
                        {
                            return parametroUno / parametroDos;
                        }
                        else
                        {
                            break;
                        }
                }
            }
            return double.NaN;
        }

        private static bool Validar (double parametroDos)
        {
            if( parametroDos != 0 )
            {
                return true;
            }
            return false;
        }
    }
}