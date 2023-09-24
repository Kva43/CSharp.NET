using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
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
                    if (DistintoDeCero(operando2))
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

        private static bool DistintoDeCero(double num)
        {
            return num != 0;
        }
    }
}
