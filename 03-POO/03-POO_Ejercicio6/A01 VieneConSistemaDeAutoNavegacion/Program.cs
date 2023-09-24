using System;
using System.Diagnostics;
using VienenConSistemaDeAutoNavegacion;

namespace A01_VieneConSistemaDeAutoNavegacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor1 = new Conductor("Carlos", new int[] { 200, 300, 102 , 50, 0} );
            Conductor conductor2 = new Conductor("Caba", new int[] { 200, 300, 101 , 10, 0} );
            Conductor conductor3 = new Conductor("Cris", new int[] { 1, 2, 103 , 20, 0} );

            Conductor[] conductores = { conductor1, conductor2, conductor3 };
            
            Conductor conductorMasKm = Conductor.MayorRecorridoSemanal(conductores);
            Conductor conductorMasKmDiaTres = Conductor.MayorRecorridoDiaTres(conductores);
            Conductor conductorMasKmDiaCinco = Conductor.MayorRecorridoDiaCinco(conductores);

            Console.WriteLine($"El conductor que hizo mayor recorrido fue: {conductorMasKm.Nombre}");
            Console.WriteLine($"El conductor que hizo mayor recorrido el dia 3 fue: {conductorMasKmDiaTres.Nombre}");
            Console.WriteLine($"El conductor que hizo mayor recorrido el dia 5 fue: {conductorMasKmDiaCinco.Nombre}");
        }
    }
}