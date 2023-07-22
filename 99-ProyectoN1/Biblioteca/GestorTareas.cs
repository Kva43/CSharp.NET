using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestorTareas : IGestorTareas
        
    {
        public List<Tarea> lista;

        public GestorTareas()
        {
            lista = new List<Tarea>();
        }
        public void AgregarTarea(Tarea tarea)
        {
            lista.Add(tarea);
        }

        public List<Tarea> ListarTareas()
        {
            return lista;
        }
    }
}
