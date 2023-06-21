using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Atrapame_si_puedes_Excepciones_CLASE_10
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() { }
        public ParametrosVaciosException(string mensaje) : base(mensaje) { }
        public ParametrosVaciosException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }

    public class ParametrosNoParseadosException : Exception
    {
        public ParametrosNoParseadosException(string mensaje) : base(mensaje) { }
    }

    public class FormatException : Exception
    {
        public FormatException(string mensaje) : this(mensaje, null) { }
        public FormatException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
