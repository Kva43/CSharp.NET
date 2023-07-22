using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class TareaSimple : Tarea
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Tarea Simple - Id: {Id}, Descripcion: {Descripcion}, Completada: {Completada}");
        }
    }
}
