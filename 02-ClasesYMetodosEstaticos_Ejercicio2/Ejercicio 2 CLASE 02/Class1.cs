using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Calculadora
    {
        public static double Calcular(double operando1, double operando2, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if (Validar(operando2))
                    {
                        resultado = (operando1 / operando2);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                    }
                    break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }
            return resultado;
        }

        private static bool Validar(double op2)
        {
            if (op2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
