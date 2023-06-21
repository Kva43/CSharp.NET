using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IO2_CLASE_10
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() : base("Los parámetros no pueden estar vacíos.")
        {
        }
    }

}
