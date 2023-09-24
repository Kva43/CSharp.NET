using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Lanzar_y_atrapar_Excepciones
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message) : base(message)
        {
        }
    }
}
