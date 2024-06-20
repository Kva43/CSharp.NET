using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Lanzar_y_atrapar_Excepciones
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message) : base(message)
        {
        }
    }
}
