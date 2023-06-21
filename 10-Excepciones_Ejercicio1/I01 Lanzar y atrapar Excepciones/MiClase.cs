using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace I01_Lanzar_y_atrapar_Excepciones
{
    public class MiClase
    {

        static void MetodoEstatico()
        {
            throw new DivideByZeroException("Error. División por cero.");
        }

        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw new MiExcepcion("Error en MiClase.");
            }
        }

        public MiClase(string message)
        {
            try
            {
                new MiClase();
            }
            catch (MiExcepcion ex)
            {
                // Capturar la excepción y lanzar una nueva excepción UnaExcepcion
                throw new UnaExcepcion(message);
            }
        }
    }
}
